using System.Collections.Generic;
using EloBuddy;

namespace AutoBuddy.Utilities.AutoShop
{
    internal abstract class IItem
    {
        public abstract int BaseGold { get; }
        public abstract IEnumerable<IItem> BuiltFrom { get; }
        public abstract int Id { get; }
        public abstract IEnumerable<int> Maps { get; }
        public abstract string Name { get; }
        public abstract bool Purchaseable { get; }
        public abstract IEnumerable<Champion> RequiredChampions { get; }
        public abstract int SellGold { get; }
        public override string ToString()
        {
            return Name;
        }

        public bool IsHealthlyConsumable()
        {
            return Id == 2003 || Id == 2009 || Id == 2010;
        }
    }
}
