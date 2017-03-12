using System;
using System.Linq;
using AutoBuddy.Utilities.AutoShop;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;
using Color = System.Drawing.Color;

namespace AutoBuddy.MainLogics
{
    internal class Recall
    {
        private readonly Slider flatGold, goldPerLevel;
        private readonly LogicSelector current;
        private readonly Obj_SpawnPoint spawn;
        private bool active;
        private GrassObject g;
        //private float lastRecallGold;
        private float lastRecallTime;
        private int recallsWithGold; //TODO repair shop and remove this tempfix

        public Recall(LogicSelector currentLogic, Menu parMenu)
        {
            var menu = parMenu.AddSubMenu("Recall settings", "ergtrh");
            menu.AddLabel(
    @"
Autobuddy will recall only if your HP/MP is lower than the percentage you specified.
(defaulted to 25% HP/15% MP)
So you won't lose easy kills just because you have enough gold to buy something.
            ");
            current = currentLogic;
            foreach (
                var so in
                    ObjectManager.Get<Obj_SpawnPoint>().Where(so => so.Team == ObjectManager.Player.Team))
            {
                spawn = so;
            }
            Core.DelayAction(ShouldRecall, 3000);
            if (MainMenu.GetMenu("AB").Get<CheckBox>("debuginfo").CurrentValue)
                Drawing.OnDraw += Drawing_OnDraw;
        }


        private void ShouldRecall()
        {
            if (active)
            {
                Core.DelayAction(ShouldRecall, 500);
                return;
            }
            if (current.current == LogicSelector.MainLogics.CombatLogic)
            {
                Core.DelayAction(ShouldRecall, 500);
                return;
            }

            if (AutoWalker.p.HealthPercent() < Program.recallHp || AutoWalker.p.ManaPercent() < Program.recallMana)
            {
                current.SetLogic(LogicSelector.MainLogics.RecallLogic);
            }
            Core.DelayAction(ShouldRecall, 500);
        }

        public void Activate()
        {
            if (active) return;
            active = true;
            g = null;
            Game.OnTick += Game_OnTick;
        }

        public void Deactivate()
        {
            lastRecallTime = 0;
            active = false;
            Game.OnTick -= Game_OnTick;
        }

        private void Drawing_OnDraw(EventArgs args)
        {
            Drawing.DrawText(250, 55, Color.Gold, "Recall, active: " + active + " next item: " + ShopGlobals.Next + " gold needed:" + ShopGlobals.GoldForNextItem);
        }

        private void Game_OnTick(EventArgs args)
        {
            AutoWalker.SetMode(Orbwalker.ActiveModes.Combo);
            if (ObjectManager.Player.Distance(spawn) < 400 && ObjectManager.Player.HealthPercent() > 85 &&
                (ObjectManager.Player.ManaPercent > 80 || ObjectManager.Player.PARRegenRate <= .0001))

                current.SetLogic(LogicSelector.MainLogics.PushLogic);
            else if (ObjectManager.Player.Distance(spawn) < 2000)
                AutoWalker.WalkTo(spawn.Position);
            else if (!ObjectManager.Player.IsRecalling() && Game.Time > lastRecallTime)
            {
                var nearestTurret =
                    ObjectManager.Get<Obj_AI_Turret>()
                        .Where(t => t.Team == ObjectManager.Player.Team && !t.IsDead())
                        .OrderBy(t => t.Distance(ObjectManager.Player))
                        .First();
                var recallPos = nearestTurret.Position.Extend(spawn, 300).To3DWorld();
                if (AutoWalker.p.HealthPercent() > 35)
                {
                    if (g == null)
                    {

                        g = ObjectManager.Get<GrassObject>()
                            .Where(gr => gr.Distance(AutoWalker.MyNexus) < AutoWalker.p.Distance(AutoWalker.MyNexus)&&gr.Distance(AutoWalker.p)>Orbwalker.HoldRadius)
                            .OrderBy(gg => gg.Distance(AutoWalker.p)).FirstOrDefault(gr => ObjectManager.Get<GrassObject>().Count(gr2=>gr.Distance(gr2)<65)>=4);
                    }
                    if (g != null && g.Distance(AutoWalker.p) < nearestTurret.Position.Distance(AutoWalker.p))
                    {
                        AutoWalker.SetMode(Orbwalker.ActiveModes.Flee);
                        recallPos = g.Position;
                    }
                }

                if ((!AutoWalker.p.IsMoving && ObjectManager.Player.Distance(recallPos) < Orbwalker.HoldRadius + 50) || (AutoWalker.p.IsMoving && ObjectManager.Player.Distance(recallPos) < 50))
                {
                    CastRecall();
                }
                else
                    AutoWalker.WalkTo(recallPos);
            }
        }

        private void CastRecall()
        {
            if (ObjectManager.Player.Distance(spawn) < 500) return;
            Core.DelayAction(CastRecall2, 300);
        }
        private void CastRecall2()//Kappa
        {
            if (ObjectManager.Player.Distance(spawn) < 500)
                return;

            if (!AutoWalker.Recalling())
            {
                if (AutoWalker.Recall.CanCast(AutoWalker.p))
                {
                    AutoWalker.Recall.Cast();
                }
            }       
        }
    }
}
