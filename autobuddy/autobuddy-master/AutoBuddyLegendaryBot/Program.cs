using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using AutoBuddy.Humanizers;
using AutoBuddy.MainLogics;
using AutoBuddy.MyChampLogic;
using AutoBuddy.Utilities.AutoLvl;
using AutoBuddy.Utilities.AutoShop;
using EloBuddy;
using EloBuddy.Sandbox;
using EloBuddy.SDK;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;
using SharpDX;

namespace AutoBuddy
{
    internal static class Program
    {
        private static AIHeroClient myHero => Player.Instance;
        private static Menu menu;
        private static string loadTextureDir = SandboxConfig.DataDirectory + "AutoBuddy\\";
        private static IChampLogic myChamp;
        private static LogicSelector Logic { get; set; }
        public static Item BlackSpear;
        public static int hpvaluePot;
        public static int recallHp;
        public static int recallMana;
        public static void Main()
        {
            Hacks.RenderWatermark = false;
            if (File.Exists(loadTextureDir + "loadTexture"))
            {
                Hacks.DisableTextures = true;
                ManagedTexture.OnLoad += args => { args.Process = false; };
            }
            Loading.OnLoadingComplete += Loading_OnLoadingComplete;
        }

        private static void Loading_OnLoadingComplete(EventArgs args)
        {
            // SR Check
            if (Game.MapId != GameMapId.SummonersRift) {
              Chat.Print("AutoBuddy (LegendaryBot Custom by James) won't run in outside Summoner's Rift!", System.Drawing.Color.LimeGreen);
              return;
            }
            //AutoBlack Spear
            if (myHero.Hero == Champion.Kalista)
            {
                BlackSpear = new Item(ItemId.The_Black_Spear);
                Chat.Print("Auto Black Spear loaded! Thanks @Enelx");
                Game.OnUpdate += On_Update;
            }
            //Causes freeze
            //Telemetry.Init(Path.Combine(SandboxConfig.DataDirectory
            //, "AutoBuddy"));

            //STILL BROKEN ;(
            //createFS();
            var v = Assembly.GetExecutingAssembly().GetName().Version;
            var ABVersion = $"{v.Major}.{v.MajorRevision}.{v.Minor}.{v.MinorRevision}";

            Chat.Print("AutoBuddy (LegendaryBot Custom by James):", System.Drawing.Color.White);
            Chat.Print($"Loaded Version: {ABVersion} (LegendaryBot Custom by James)", System.Drawing.Color.LimeGreen);
            Chat.Print("https://www.elobuddy.net/profile/344532-jamesphp",System.Drawing.Color.LimeGreen);
            Chat.Print("http://legendary.zone/profile/1477-james",System.Drawing.Color.LimeGreen);
            Chat.Print("https://paypal.me/JamesLoL",System.Drawing.Color.LimeGreen);
            Chat.Print("AutoBuddy (LegendaryBot Custom by James): Starting in 5 seconds.");
            var startTime = Game.Time < 13
                ? (13000 - (int) (Game.Time * 1000) < 5000 ? 5000 : 13000 - (int) (Game.Time * 1000))
                : 5000;
            Core.DelayAction(Start, startTime);
            menu = MainMenu.AddMenu("AUTOBUDDY", "AB");
            menu.Add("sep1", new Separator(1));
            var c = new CheckBox("Call mid, will leave if other player stays on mid(only auto lane)");
            var property2 = typeof(CheckBox).GetProperty("Size");
            property2.GetSetMethod(true).Invoke(c, new object[] {new Vector2(500, 20)});
            menu.Add("mid", c);
            var s = menu.Add("lane", new Slider(" ", 1, 1, 4));
            string[] lanes =
            {
                "",
                "Selected lane: Auto",
                "Selected lane: Top",
                "Selected lane: Mid",
                "Selected lane: Bot"
            };
            s.DisplayName = lanes[s.CurrentValue];
            s.OnValueChange +=
                delegate (ValueBase<int> sender, ValueBase<int>.ValueChangeArgs changeArgs)
                {
                    sender.DisplayName = lanes[changeArgs.NewValue];
                };
            menu.Add("reselectlane", new CheckBox("Reselect lane", false));
            menu.Add("disablepings", new CheckBox("Disable pings"));
            menu.Add("disablechat", new CheckBox("Disable chat"));
            var newpf = new CheckBox("Use smart pathfinder");
            menu.Add("newPF", newpf);
            var hpValue = menu.Add("HPPot", new Slider("Minimum HP% to use Health Pot?", 40, 1));
            hpvaluePot = hpValue.CurrentValue;
            hpValue.OnValueChange += delegate
            {
                hpvaluePot = hpValue.CurrentValue;
            };
            newpf.OnValueChange += newpf_OnValueChange;
            var hpRecall = menu.Add("recallHp", new Slider("HP% to recall?", 25));
            var mpRecall = menu.Add("recallMp", new Slider("Mana% to recall?", 15));
            hpRecall.OnValueChange += delegate
            {
                recallHp = hpRecall.CurrentValue;
            };
            mpRecall.OnValueChange += delegate
            {
                recallMana = mpRecall.CurrentValue;
            };
            recallHp = hpRecall.CurrentValue;
            recallMana = mpRecall.CurrentValue;
            menu.AddSeparator(10);
            menu.AddLabel("Turn on to improve RAM usage.");
            var noTextures = new CheckBox("Don't load textures. Restart LoL to apply.");
            menu.Add("noTextures", noTextures);
            noTextures.OnValueChange += noTextures_OnValueChange;
            menu.Add("sep2", new Separator(10));
            menu.AddLabel("Champ will follow cursor. DO NOT TURN ON IF YOU ARE BOTTING!");
            menu.Add("disableAutoBuddy", new CheckBox("Disable AutoBuddy Movement. F5 to apply.", false));
            menu.AddSeparator(5);
            var autoclose = new CheckBox("Auto close lol when the game ends. F5 to apply");
            property2.GetSetMethod(true).Invoke(autoclose, new object[] {new Vector2(500, 20)});
            menu.Add("autoclose", autoclose);
            menu.AddSeparator(5);
            menu.Add("oldWalk", new CheckBox("Use old orbwalking. F5 to apply", false));
            menu.Add("debuginfo", new CheckBox("Draw debug info. F5 to apply"));
            menu.Add("spdghofj", new Separator(10));
            menu.Add("z", new Label("If you want to use external champion addons, disable this option and press F5."));
            menu.Add("z1", new Label("Also, it's HIGHLY RECOMMENDED to use custom builds if you do because"));
            menu.Add("z2", new Label("AutoBuddy will then be defaulted to its general, made-for-any-carry build."));
            menu.Add("toUseOurChampLogic", new CheckBox("Use AutoBuddy's champion logic. F5 to apply."));
            menu.Add("z3", new Separator(2));
            menu.Add("l1", new Label("By Christian Brutal Sniper - Was maintained by TheYasuoMain - Now maintaned by FurkanS"));
            menu.Add("l2", new Label($"Version: {ABVersion}"));
        }

        static void newpf_OnValueChange(ValueBase<bool> sender, ValueBase<bool>.ValueChangeArgs args)
        {
            AutoWalker.newPF = args.NewValue;
        }
        static void noTextures_OnValueChange(ValueBase<bool> sender, ValueBase<bool>.ValueChangeArgs args)
        {
            //Creates a file so that AutoBuddy can check on load if the user doesn't want textures.. :) Thanks @Finndev!
            try
            {
                if (!Directory.Exists(loadTextureDir))
                {
                    Directory.CreateDirectory(loadTextureDir);
                }
                if (MainMenu.GetMenu("AB").Get<CheckBox>("noTextures").CurrentValue)
                {
                    if (!File.Exists(loadTextureDir + "loadTexture"))
                    {
                        File.Create(loadTextureDir + "loadTexture");
                    }
                }
                else
                {
                    if (File.Exists(loadTextureDir + "loadTexture"))
                    {
                        File.Delete(loadTextureDir + "loadTexture");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Load Texture Error: '{e}'");
            }
        }

        //For Kalista
        private static void On_Update(EventArgs args)
        {
            if (BlackSpear.IsOwned())
            {
                if (myHero.CountAllyChampionsInRange(BlackSpear.Range) == 1)
                {
                    BlackSpear.Cast(EntityManager.Allies.Find(x => x.Distance(myHero) < BlackSpear.Range));
                }
            }
        }
        //For Kalista

        private static void Start()
        {
            RandGen.Start();
            var generic = false;
            if (menu.Get<CheckBox>("toUseOurChampLogic").CurrentValue)
            {
                switch (ObjectManager.Player.Hero)
                {
                    case Champion.Aatrox:
                        goto default;
                    case Champion.Ahri:
                        myChamp = new Ahri();
                        break;
                    case Champion.Akali:
                        goto default;
                    case Champion.Alistar:
                        goto default;
                    case Champion.Amumu:
                        goto default;
                    case Champion.Anivia:
                        myChamp = new Anivia();
                        break;
                    case Champion.Annie:
                        myChamp = new Annie();
                        break;
                    case Champion.Ashe:
                        myChamp = new Ashe();
                        break;
                    case Champion.AurelionSol:
                        goto default;
                    case Champion.Azir:
                        myChamp = new Azir();
                        break;
                    case Champion.Bard:
                        goto default;
                    case Champion.Blitzcrank:
                        goto default;
                    case Champion.Brand:
                        myChamp = new Brand();
                        break;
                    case Champion.Braum:
                        goto default;
                    case Champion.Caitlyn:
                        myChamp = new Caitlyn();
                        break;
                    case Champion.Camille:
                        goto default;
                    case Champion.Cassiopeia:
                        myChamp = new Cassiopeia();
                        break;
                    case Champion.Chogath:
                        goto default;
                    case Champion.Corki:
                        myChamp = new Corki();
                        break;
                    case Champion.Darius:
                        goto default;
                    case Champion.Diana:
                        goto default;
                    case Champion.DrMundo:
                        goto default;
                    case Champion.Draven:
                        myChamp = new Draven();
                        break;
                    case Champion.Ekko:
                        goto default;
                    case Champion.Elise:
                        goto default;
                    case Champion.Evelynn:
                        goto default;
                    case Champion.Ezreal:
                        myChamp = new Ezreal();
                        break;
                    case Champion.FiddleSticks:
                        goto default;
                    case Champion.Fiora:
                        goto default;
                    case Champion.Fizz:
                        goto default;
                    case Champion.Galio:
                        goto default;
                    case Champion.Gangplank:
                        goto default;
                    case Champion.Garen:
                        myChamp = new Garen();
                        break;
                    case Champion.Gnar:
                        goto default;
                    case Champion.Gragas:
                        goto default;
                    case Champion.Graves:
                        goto default;
                    case Champion.Hecarim:
                        goto default;
                    case Champion.Heimerdinger:
                        goto default;
                    case Champion.Illaoi:
                        goto default;
                    case Champion.Irelia:
                        goto default;
                    case Champion.Ivern:
                        goto default;
                    case Champion.Janna:
                        goto default;
                    case Champion.JarvanIV:
                        goto default;
                    case Champion.Jax:
                        goto default;
                    case Champion.Jayce:
                        goto default;
                    case Champion.Jhin:
                        goto default;
                    case Champion.Jinx:
                        myChamp = new Jinx();
                        break;
                    case Champion.Kalista:
                        myChamp = new Kalista();
                        break;
                    case Champion.Karma:
                        goto default;
                    case Champion.Karthus:
                        goto default;
                    case Champion.Kassadin:
                        goto default;
                    case Champion.Katarina:
                        myChamp = new Katarina();
                        break;
                    case Champion.Kayle:
                        myChamp = new Kayle();
                        break;
                    case Champion.Kennen:
                        goto default;
                    case Champion.Khazix:
                        goto default;
                    case Champion.Kindred:
                        goto default;
                    case Champion.Kled:
                        goto default;
                    case Champion.KogMaw:
                        goto default;
                    case Champion.Leblanc:
                        myChamp = new Leblanc();
                        break;
                    case Champion.LeeSin:
                        goto default;
                    case Champion.Leona:
                        goto default;
                    case Champion.Lissandra:
                        goto default;
                    case Champion.Lucian:
                        goto default;
                    case Champion.Lulu:
                        goto default;
                    case Champion.Lux:
                        goto default;
                    case Champion.Malphite:
                        goto default;
                    case Champion.Malzahar:
                        goto default;
                    case Champion.Maokai:
                        goto default;
                    case Champion.MasterYi:
                        goto default;
                    case Champion.MissFortune:
                        goto default;
                    case Champion.Mordekaiser:
                        goto default;
                    case Champion.Morgana:
                        myChamp = new Morgana();
                        break;
                    case Champion.Nami:
                        goto default;
                    case Champion.Nasus:
                        goto default;
                    case Champion.Nautilus:
                        goto default;
                    case Champion.Nidalee:
                        myChamp = new Nidalee();
                        break;
                    case Champion.Nocturne:
                        goto default;
                    case Champion.Nunu:
                        goto default;
                    case Champion.Olaf:
                        goto default;
                    case Champion.Orianna:
                        goto default;
                    case Champion.Pantheon:
                        goto default;
                    case Champion.Poppy:
                        goto default;
                    case Champion.Quinn:
                        goto default;
                    case Champion.Rammus:
                        goto default;
                    case Champion.RekSai:
                        goto default;
                    case Champion.Renekton:
                        goto default;
                    case Champion.Rengar:
                        goto default;
                    case Champion.Riven:
                        goto default;
                    case Champion.Rumble:
                        goto default;
                    case Champion.Ryze:
                        myChamp = new Ryze();
                        break;
                    case Champion.Sejuani:
                        goto default;
                    case Champion.Shaco:
                        goto default;
                    case Champion.Shen:
                        goto default;
                    case Champion.Shyvana:
                        goto default;
                    case Champion.Singed:
                        goto default;
                    case Champion.Sion:
                        goto default;
                    case Champion.Sivir:
                        myChamp = new Sivir();
                        break;
                    case Champion.Skarner:
                        goto default;
                    case Champion.Sona:
                        goto default;
                    case Champion.Soraka:
                        myChamp = new Soraka();
                        break;
                    case Champion.Swain:
                        goto default;
                    case Champion.Syndra:
                        goto default;
                    case Champion.TahmKench:
                        goto default;
                    case Champion.Taliyah:
                        goto default;
                    case Champion.Talon:
                        goto default;
                    case Champion.Taric:
                        goto default;
                    case Champion.Teemo:
                        goto default;
                    case Champion.Thresh:
                        goto default;
                    case Champion.Tristana:
                        myChamp = new Tristana();
                        break;
                    case Champion.Trundle:
                        goto default;
                    case Champion.Tryndamere:
                        goto default;
                    case Champion.TwistedFate:
                        goto default;
                    case Champion.Twitch:
                        myChamp = new Twitch();
                        break;
                    case Champion.Udyr:
                        goto default;
                    case Champion.Urgot:
                        goto default;
                    case Champion.Varus:
                        goto default;
                    case Champion.Vayne:
                        goto default;
                    case Champion.Veigar:
                        goto default;
                    case Champion.Velkoz:
                        myChamp = new Velkoz();
                        break;
                    case Champion.Vi:
                        goto default;
                    case Champion.Viktor:
                        goto default;
                    case Champion.Vladimir:
                        goto default;
                    case Champion.Volibear:
                        goto default;
                    case Champion.Warwick:
                        goto default;
                    case Champion.MonkeyKing:
                        goto default;
                    case Champion.Xerath:
                        myChamp = new Xerath();
                        break;
                    case Champion.XinZhao:
                        goto default;
                    case Champion.Yasuo:
                        goto default;
                    case Champion.Yorick:
                        goto default;
                    case Champion.Zac:
                        goto default;
                    case Champion.Zed:
                        goto default;
                    case Champion.Ziggs:
                        goto default;
                    case Champion.Zilean:
                        goto default;
                    case Champion.Zyra:
                        goto default;
                    default:
                        generic = true;
                        myChamp = new Generic();
                        break;
                }
            }
            else
            {
                generic = true;
                myChamp = new Generic();
            }
            var cl = new CustomLvlSeq(menu, AutoWalker.p, Path.Combine(SandboxConfig.DataDirectory, "AutoBuddy\\Skills"));
            if (!generic)
            {
                var bc = new BuildCreator(menu, Path.Combine(SandboxConfig.DataDirectory
                    , "AutoBuddy\\Builds"), myChamp.ShopSequence);
            }
            else
            {
                if (MainMenu.GetMenu("AB_" + ObjectManager.Player.ChampionName) != null &&
                    MainMenu.GetMenu("AB_" + ObjectManager.Player.ChampionName).Get<Label>("shopSequence") != null)
                {
                    Chat.Print("AutoBuddy (LegendaryBot Custom by James): Loaded shop plugin for " + ObjectManager.Player.ChampionName);
                    var bc = new BuildCreator(menu, Path.Combine(SandboxConfig.DataDirectory
                        , "AutoBuddy\\Builds"),
                        MainMenu.GetMenu("AB_" + ObjectManager.Player.ChampionName)
                            .Get<Label>("shopSequence")
                            .DisplayName);
                }
                else
                {
                    var bc = new BuildCreator(menu, Path.Combine(SandboxConfig.DataDirectory
                        , "AutoBuddy\\Builds"), myChamp.ShopSequence);
                }
            }
            Logic = new LogicSelector(myChamp, menu);
        }

        private static void createFS()
        {
            try
            {
                if (!Directory.Exists(Path.Combine(SandboxConfig.DataDirectory, "AutoBuddy")))
                {
                    Directory.CreateDirectory(Path.Combine(SandboxConfig.DataDirectory, "AutoBuddy"));
                }
                if (!Directory.Exists(Path.Combine(SandboxConfig.DataDirectory, "AutoBuddy", "Builds")))
                {
                    Directory.CreateDirectory(Path.Combine(SandboxConfig.DataDirectory, "AutoBuddy", "Builds"));
                }
                if (!Directory.Exists(Path.Combine(SandboxConfig.DataDirectory, "AutoBuddy", "Skills")))
                {
                    Directory.CreateDirectory(Path.Combine(SandboxConfig.DataDirectory, "AutoBuddy", "Skills"));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"CreateFS Error: '{e}'");
            }
        }
    }
}
