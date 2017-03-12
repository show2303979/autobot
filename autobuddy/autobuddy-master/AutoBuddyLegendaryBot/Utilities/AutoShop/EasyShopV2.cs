using System.Collections.Generic;
using System.Linq;
using AutoBuddy.Humanizers;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Menu.Values;

namespace AutoBuddy.Utilities.AutoShop
{
    internal enum ShopActionType
    {
        Buy = 1,
        Sell = 2,
        StartHpPot = 3,
        StopHpPot = 4
    }

    public static class ShopGlobals
    {
        public static int GoldForNextItem = 999999;
        public static string Next;
    }

    internal class EasyShopV2
    {
        private readonly List<BuildElement> buildElements;
        private readonly CheckBox enabled;
        private bool first = false;

        public EasyShopV2(List<BuildElement> elements, CheckBox en)
        {
            enabled = en;
            buildElements = elements;
            Shopping();
        }

        private void Shopping()
        {
            var myit = BrutalItemInfo.MyItems();
            if (!first && (!enabled.CurrentValue || !ObjectManager.Player.IsInShopRange() || !buildElements.Any()))
            {
                first = true;
                Core.DelayAction(Shopping, 300);
                return;
            }

            ShopGlobals.GoldForNextItem = 9999999;
            var currentPos = BrutalItemInfo.GetNum(buildElements);
            if (currentPos == -1)
                ShopGlobals.Next = "Inventories mismatch, won't buy any items";
            if (currentPos == 0) // Run when currentPos is 0
            {
                if (!myit.Any()) // Run when we have no items
                {
                    if (Shop.CanShop)
                    {
                        Shop.BuyItem(buildElements.First(el => el.position == 1).item.Id);
                    }
                    Core.DelayAction(Shopping, 800);
                    return;
                }
            }
            if (currentPos + 2 > buildElements.Count) // Run when inventory is full of what needed
            {
                Core.DelayAction(Shopping, RandGen.r.Next(400, 800));
                return;
            }

            if (buildElements.First(b => b.position == currentPos + 2).action != ShopActionType.Buy) // Run when next action is not buy
                foreach (
                    var buildElement in
                        buildElements.Where(b => b.position > currentPos + 1).OrderBy(b => b.position).ToList())
                {
                    if (buildElement.action == ShopActionType.Buy || buildElement.action == ShopActionType.Sell) break;

                    currentPos++;
                    if (currentPos + 2 > buildElements.Count)
                    {
                        Core.DelayAction(Shopping, RandGen.r.Next(400, 800));
                        return;
                    }
                }


            if (currentPos < buildElements.Count - 1) // Run if we have slots to buy
            {
                var b = buildElements.First(el => el.position == currentPos + 2);
                if (b.action == ShopActionType.Sell)
                {
                    var slot = BrutalItemInfo.GetItemSlot(buildElements.First(el => el.position == currentPos + 2).item.Id);
                    if (slot != -1)
                    {
                        if (Shop.CanShop)
                        {
                            Shop.SellItem(slot); 
                        }

                    }
                    else
                    {
                        b = buildElements.First(el => el.position == currentPos + 3);
                    }
                }

                if (b.action == ShopActionType.Buy)
                {
                    ShopGlobals.Next = b.item.Name;
                    ShopGlobals.GoldForNextItem = BrutalItemInfo.BuyItemSim(myit, b.item);
                    if (Shop.CanShop)
                    {
                        Shop.BuyItem(b.item.Id); 
                    }
                }

            }


            Core.DelayAction(() =>
            {
                if (currentPos == -1) return;
                var cur = buildElements.Where(b => b.position < currentPos + 2).ToList();

                var hp = cur.Count(e => e.action == ShopActionType.StartHpPot) -
                         cur.Count(e => e.action == ShopActionType.StopHpPot);
                if (hp > 0 && !AutoWalker.p.InventoryItems.Any(it => it.Id.IsHealthlyConsumable()))
                    if (Shop.CanShop)
                        Shop.BuyItem(ItemId.Health_Potion);
                else if (hp <= 0)
                {
                    var slot = BrutalItemInfo.GetHealtlyConsumableSlot();
                    if (slot != -1)
                        if (Shop.CanShop)
                            Shop.SellItem(slot);
                }
            }
                , 150);

            Core.DelayAction(Shopping, RandGen.r.Next(600, 1000));
        }
    }
}