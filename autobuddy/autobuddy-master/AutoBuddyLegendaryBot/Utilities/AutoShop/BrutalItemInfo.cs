using System.Collections.Generic;
using System.Linq;
using EloBuddy;

namespace AutoBuddy.Utilities.AutoShop
{
    internal static class BrutalItemInfo
    {
        public static readonly IItem[] itemDB;
        public static readonly IItem[] avItemDB;

        static BrutalItemInfo()
        {
            var all = new List<IItem>();
            var av = new List<IItem>();
            for (var i = 1000; i < 5000; i++)
            {
                var item = Items.GetItemById(i);
                if (item == null) continue;
                all.Add(item);
                if (item.Purchaseable && item.Maps.Contains((int) Game.MapId) && (!item.RequiredChampions.Any() || item.RequiredChampions.Contains(AutoWalker.p.Hero)))
                {
                    av.Add(item);
                }
            }
            itemDB = all.ToArray();
            avItemDB = av.ToArray();
        }

        public static IItem FindBestItem(this List<IItem> items, string name)
        {
            return items.OrderByDescending(it => it.Name.Match(name)).First();
        }

        public static IItem FindBestItem(this IItem[] items, string name)
        {
            return items.OrderByDescending(it => it.Name.Match(name)).First();
        }

        public static IItem FindBestItem(string name)
        {
            return avItemDB.OrderByDescending(it => it.Name.Match(name)).First();
        }

        public static IItem FindBestItemAll(string name)
        {
            return itemDB.OrderByDescending(it => it.Name.Match(name)).First();
        }

        public static IItem FindItemByID(this IItem[] items, int id)
        {
            return items.OrderByDescending(it => it.Id == id).First();
        }

        public static IItem FindItemByID(this List<IItem> items, int id)
        {
            return items.OrderByDescending(it => it.Id == id).First();
        }

        public static bool ItemGroupsHasRelicBase(this IItem item)
        {
            var list = new List<ItemId>
            {
                ItemId.Diet_Poro_Snax,
                ItemId.Warding_Totem_Trinket,
                ItemId.Sweeping_Lens_Trinket,
                ItemId.Soul_Anchor_Trinket,
                ItemId.Arcane_Sweeper,
                ItemId.Greater_Stealth_Totem_Trinket,
                ItemId.Greater_Vision_Totem_Trinket,
                ItemId.Farsight_Alteration,
                ItemId.Oracle_Alteration,
                ItemId.Golden_Transcendence,
                ItemId.Golden_Transcendence_Disabled,
                ItemId.Seer_Stone_Trinket
            };
            return list.Contains((ItemId)item.Id);
        }

        public static IItem GetItemByID(int id)
        {
            return itemDB.First(it => it.Id == id);
        }

        public static int InventorySimulator(List<BuildElement> elements, List<IItem> playerInv, int num = int.MaxValue)
        {
            var n = 0;
            var gold = 0;
            foreach (var el in elements.OrderBy(el => el.position))
            {
                if (n >= num)
                    return gold;
                n++;
                if (el.action == ShopActionType.Buy)
                {
                    gold += BuyItemSim(playerInv, el.item);
                    playerInv.Add(el.item);
                }
                else if (el.action == ShopActionType.Sell)
                {
                    gold -= SellItemSim(playerInv, el.item);
                }
                else if (el.action == ShopActionType.StartHpPot)
                {
                    gold += BuyItemSim(playerInv, el.item);
                    if (playerInv.FirstOrDefault(ii => ii.Id == (int)ItemId.Health_Potion) == null)
                        playerInv.Add(el.item);
                }
                else if (el.action == ShopActionType.StopHpPot)
                {
                    playerInv.Remove(el.item);
                }
            }
            return gold;
        }

        public static List<IItem> MyItems()
        {
            var items = AutoWalker.p.InventoryItems.Select(x => itemDB.FindItemByID((int) x.Id)).ToList();
            items.RemoveAll(x => x.Id == 1000);
            return items;
        }

        public static int GetNum(List<BuildElement> elements)
        {
            var n = 0;
            var myItems = MyItems();
            var virtInv = new List<IItem>();
            foreach (var el in elements.OrderBy(el => el.position))
            {
                if (el.action == ShopActionType.Buy)
                {
                    BuyItemSim(virtInv, el.item);
                    virtInv.Add(el.item);
                    if (virtInv.Equal(myItems))
                    {
                        return n;
                    }
                }
                n++;
            }
            return -1;
        }

        /*public static bool Equal(this List<IItem> virtInv, List<IItem> charInv, bool ignorePotions = true)
        {
            if (!virtInv.Any() && !charInv.Any()) return true;
            List<IItem> lTwo = new List<IItem>(charInv);
            foreach (IItem itOne in virtInv)
            {
                bool cont = false;
                if (itOne.IsHealthlyConsumable()) continue;
                foreach (IItem itTwo in lTwo)
                {
                    Chat.Print(itTwo.IsHealthlyConsumable());
                    if (itOne.id == itTwo.id || itTwo.IsHealthlyConsumable() || !itTwo.purchasable)
                    {
                        lTwo.Remove(itTwo);
                        cont = true;
                        break;
                    }
                }
                if (!cont) return false;
            }

            return !lTwo.Any();
        }*/

        private static bool Equal(this List<IItem> virtInv, List<IItem> charInv, bool ignorePotions = true)
        {
            if (!virtInv.Any() && !charInv.Any())
                return true;
            var inv1 = virtInv.Where(it => !it.IsHealthlyConsumable() && it.Id != 3599).ToList();
            var inv2 = charInv.Where(it => !it.IsHealthlyConsumable() && it.Id != 3599).ToList();

            foreach (var item1 in inv1)
            {

                foreach (var item2 in inv2.ToList())
                {
                    if (SameItems(item1.Id, item2.Id))
                    {
                        inv2.Remove(item2);
                        break;
                    }
                }
            }

            if (inv2.Any())
            //Chat.Print("1: " + inv1.OrderBy(it => it.name).Concatenate(", "));
            //Chat.Print("2: " + inv2.OrderBy(it => it.name).Concatenate(", "));
            {

            }
            return !inv2.Any();
        }

        public static bool SameItems(int id1, int id2)
        {
            if (id1 == id2) return true;
            if ((id1 == 3003 && id2 == 3040) || (id2 == 3003 && id1 == 3040)) return true;//seraphs
            if ((id1 == 3004 && id2 == 3043) || (id2 == 3004 && id1 == 3043)) return true;//muramana

            return false;
        }

        public static int BuyItemSim(List<IItem> inventory, IItem item, bool root = true)
        {
            if (!root && inventory.Any(it => it.Id == item.Id))
            {
                inventory.Remove(inventory.First(it => it.Id == item.Id));
                return 0;
            }
            if (!item.BuiltFrom.Any())
            {
                return item.BaseGold;
            }
            var gold = item.BaseGold +
                       item.BuiltFrom.Sum(
                           fromItemID => BuyItemSim(inventory, itemDB.First(it => it.Id == fromItemID.Id), false));
            return gold;
        }

        public static int SellItemSim(List<IItem> inventory, IItem item)
        {
            if (inventory.Contains(item))
            {
                inventory.Remove(item);
                return -item.SellGold;
            }
            return -1;
        }

        public static int GetItemSlot(int id)
        {
            for (var i = 0; i < ObjectManager.Player.InventoryItems.Length; i++)
            {
                if ((int)ObjectManager.Player.InventoryItems[i].Id == id)
                    return i;
            }
            return -1;
        }

        public static int GetHealtlyConsumableSlot()
        {
            for (var i = 0; i < ObjectManager.Player.InventoryItems.Length; i++)
            {
                if (ObjectManager.Player.InventoryItems[i].Id.IsHealthlyConsumable())
                    return i;
            }
            return -1;
        }

        public static int GetHPotionSlot()
        {
            for (var i = 0; i < ObjectManager.Player.InventoryItems.Length; i++)
            {
                if (ObjectManager.Player.InventoryItems[i].Id.IsHPotion())
                    return i;
            }
            return -1;
        }
    }
}