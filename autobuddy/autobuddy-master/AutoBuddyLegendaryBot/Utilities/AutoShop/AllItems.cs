using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EloBuddy;

namespace AutoBuddy.Utilities.AutoShop
{
    class _1001 : IItem
    {
        public override int BaseGold => 300;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1001;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Boots of Speed";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 210;
    }

    class _1004 : IItem
    {
        public override int BaseGold => 125;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1004;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Faerie Charm";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 88;
    }

    class _1006 : IItem
    {
        public override int BaseGold => 150;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1006;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Rejuvenation Bead";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 105;
    }

    class _1011 : IItem
    {
        public override int BaseGold => 600;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1028() };
        public override int Id => 1011;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Giant's Belt";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 700;
    }

    class _1018 : IItem
    {
        public override int BaseGold => 800;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1018;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Cloak of Agility";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 560;
    }

    class _1026 : IItem
    {
        public override int BaseGold => 850;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1026;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Blasting Wand";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 595;
    }

    class _1027 : IItem
    {
        public override int BaseGold => 350;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1027;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Sapphire Crystal";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 245;
    }

    class _1028 : IItem
    {
        public override int BaseGold => 400;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1028;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Ruby Crystal";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 280;
    }

    class _1029 : IItem
    {
        public override int BaseGold => 300;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1029;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Cloth Armor";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 210;
    }

    class _1031 : IItem
    {
        public override int BaseGold => 500;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1029() };
        public override int Id => 1031;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Chain Vest";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 560;
    }

    class _1033 : IItem
    {
        public override int BaseGold => 450;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1033;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Null-Magic Mantle";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 315;
    }

    class _1036 : IItem
    {
        public override int BaseGold => 350;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1036;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Long Sword";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 245;
    }

    class _1037 : IItem
    {
        public override int BaseGold => 875;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1037;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Pickaxe";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 613;
    }

    class _1038 : IItem
    {
        public override int BaseGold => 1300;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1038;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "B. F. Sword";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 910;
    }

    class _1039 : IItem
    {
        public override int BaseGold => 350;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1039;
        public override IEnumerable<int> Maps => new[] { 10, 11 };
        public override string Name => "Hunter's Talisman";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 245;
    }

    class _1041 : IItem
    {
        public override int BaseGold => 350;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1041;
        public override IEnumerable<int> Maps => new[] { 10, 11 };
        public override string Name => "Hunter's Machete";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 245;
    }

    class _1042 : IItem
    {
        public override int BaseGold => 300;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1042;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Dagger";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 210;
    }

    class _1043 : IItem
    {
        public override int BaseGold => 400;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1042(), new _1042() };
        public override int Id => 1043;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Recurve Bow";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 700;
    }

    class _1051 : IItem
    {
        public override int BaseGold => 400;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1051;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Brawler's Gloves";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 280;
    }

    class _1052 : IItem
    {
        public override int BaseGold => 435;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1052;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Amplifying Tome";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 305;
    }

    class _1053 : IItem
    {
        public override int BaseGold => 550;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1036() };
        public override int Id => 1053;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Vampiric Scepter";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 630;
    }

    class _1054 : IItem
    {
        public override int BaseGold => 450;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1054;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Doran's Shield";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 180;
    }

    class _1055 : IItem
    {
        public override int BaseGold => 450;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1055;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Doran's Blade";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 180;
    }

    class _1056 : IItem
    {
        public override int BaseGold => 400;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1056;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Doran's Ring";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 160;
    }

    class _1057 : IItem
    {
        public override int BaseGold => 270;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1033() };
        public override int Id => 1057;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Negatron Cloak";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 504;
    }

    class _1058 : IItem
    {
        public override int BaseGold => 1250;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1058;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Needlessly Large Rod";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 875;
    }

    class _1082 : IItem
    {
        public override int BaseGold => 350;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1082;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "The Dark Seal";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 245;
    }

    class _1083 : IItem
    {
        public override int BaseGold => 450;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 1083;
        public override IEnumerable<int> Maps => new[] { 10, 11, 12 };
        public override string Name => "Cull";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 180;
    }

    class _1400 : IItem
    {
        public override int BaseGold => 525;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3133(), new _3706() };
        public override int Id => 1400;
        public override IEnumerable<int> Maps => new[] { 10, 11 };
        public override string Name => "Enchantment: Warrior";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1838;
    }

    class _1401 : IItem
    {
        public override int BaseGold => 525;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3751(), new _3706() };
        public override int Id => 1401;
        public override IEnumerable<int> Maps => new[] { 10, 11 };
        public override string Name => "Enchantment: Cinderhulk";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1838;
    }

    class _1402 : IItem
    {
        public override int BaseGold => 340;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3113(), new _1052(), new _3706() };
        public override int Id => 1402;
        public override IEnumerable<int> Maps => new[] { 10, 11 };
        public override string Name => "Enchantment: Runic Echoes";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1838;
    }

    class _1408 : IItem
    {
        public override int BaseGold => 525;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3133(), new _3711() };
        public override int Id => 1408;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Enchantment: Warrior";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1838;
    }

    class _1409 : IItem
    {
        public override int BaseGold => 525;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3751(), new _3711() };
        public override int Id => 1409;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Enchantment: Cinderhulk";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1838;
    }

    class _1410 : IItem
    {
        public override int BaseGold => 340;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3113(), new _1052(), new _3711() };
        public override int Id => 1410;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Enchantment: Runic Echoes";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1838;
    }

    class _1412 : IItem
    {
        public override int BaseGold => 525;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3133(), new _3715() };
        public override int Id => 1412;
        public override IEnumerable<int> Maps => new[] { 10, 11 };
        public override string Name => "Enchantment: Warrior";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1838;
    }

    class _1413 : IItem
    {
        public override int BaseGold => 525;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3751(), new _3715() };
        public override int Id => 1413;
        public override IEnumerable<int> Maps => new[] { 10, 11 };
        public override string Name => "Enchantment: Cinderhulk";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1838;
    }

    class _1414 : IItem
    {
        public override int BaseGold => 340;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3113(), new _1052(), new _3715() };
        public override int Id => 1414;
        public override IEnumerable<int> Maps => new[] { 10, 11 };
        public override string Name => "Enchantment: Runic Echoes";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1838;
    }

    class _1416 : IItem
    {
        public override int BaseGold => 625;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1043(), new _3706() };
        public override int Id => 1416;
        public override IEnumerable<int> Maps => new[] { 10, 11 };
        public override string Name => "Enchantment: Bloodrazor";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1838;
    }

    class _1418 : IItem
    {
        public override int BaseGold => 625;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1043(), new _3711() };
        public override int Id => 1418;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Enchantment: Bloodrazor";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1838;
    }

    class _1419 : IItem
    {
        public override int BaseGold => 625;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1043(), new _3715() };
        public override int Id => 1419;
        public override IEnumerable<int> Maps => new[] { 10, 11 };
        public override string Name => "Enchantment: Bloodrazor";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1838;
    }

    class _2003 : IItem
    {
        public override int BaseGold => 50;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 2003;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Health Potion";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 20;
    }

    class _2009 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 2009;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Total Biscuit of Rejuvenation";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _2010 : IItem
    {
        public override int BaseGold => 50;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 2010;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Total Biscuit of Rejuvenation";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 20;
    }

    class _2015 : IItem
    {
        public override int BaseGold => 450;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1042() };
        public override int Id => 2015;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Kircheis Shard";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 525;
    }

    class _2031 : IItem
    {
        public override int BaseGold => 150;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 2031;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Refillable Potion";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 60;
    }

    class _2032 : IItem
    {
        public override int BaseGold => 250;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _2031() };
        public override int Id => 2032;
        public override IEnumerable<int> Maps => new[] { 10, 11 };
        public override string Name => "Hunter's Potion";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 160;
    }

    class _2033 : IItem
    {
        public override int BaseGold => 350;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _2031() };
        public override int Id => 2033;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Corrupting Potion";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 200;
    }

    class _2045 : IItem
    {
        public override int BaseGold => 400;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _2049(), new _1028() };
        public override int Id => 2045;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Ruby Sightstone";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 640;
    }

    class _2047 : IItem
    {
        public override int BaseGold => 300;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 2047;
        public override IEnumerable<int> Maps => new[] { 8, 12 };
        public override string Name => "Oracle's Extract";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 120;
    }

    class _2049 : IItem
    {
        public override int BaseGold => 400;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1028() };
        public override int Id => 2049;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Sightstone";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 320;
    }

    class _2050 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 2050;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Explorer's Ward";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _2051 : IItem
    {
        public override int BaseGold => 950;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 2051;
        public override IEnumerable<int> Maps => new[] { 12 };
        public override string Name => "Guardian's Horn";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 380;
    }

    class _2052 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 2052;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Poro-Snax";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _2053 : IItem
    {
        public override int BaseGold => 250;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1006(), new _1031() };
        public override int Id => 2053;
        public override IEnumerable<int> Maps => new[] { 10, 11, 12 };
        public override string Name => "Raptor Cloak";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 840;
    }

    class _2054 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 2054;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Diet Poro-Snax";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _2055 : IItem
    {
        public override int BaseGold => 75;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 2055;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Control Ward";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 30;
    }

    class _2138 : IItem
    {
        public override int BaseGold => 500;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 2138;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Elixir of Iron";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 200;
    }

    class _2139 : IItem
    {
        public override int BaseGold => 500;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 2139;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Elixir of Sorcery";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 200;
    }

    class _2140 : IItem
    {
        public override int BaseGold => 500;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 2140;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Elixir of Wrath";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 200;
    }

    class _2301 : IItem
    {
        public override int BaseGold => 550;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _2049(), new _3098() };
        public override int Id => 2301;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Eye of the Watchers";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 880;
    }

    class _2302 : IItem
    {
        public override int BaseGold => 250;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _2049(), new _3096() };
        public override int Id => 2302;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Eye of the Oasis";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 760;
    }

    class _2303 : IItem
    {
        public override int BaseGold => 650;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _2049(), new _3097() };
        public override int Id => 2303;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Eye of the Equinox";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 920;
    }

    class _3001 : IItem
    {
        public override int BaseGold => 695;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3108(), new _1057(), new _1052() };
        public override int Id => 3001;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Abyssal Scepter";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1925;
    }

    class _3003 : IItem
    {
        public override int BaseGold => 1100;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3070(), new _1058() };
        public override int Id => 3003;
        public override IEnumerable<int> Maps => new[] { 10, 11, 12 };
        public override string Name => "Archangel's Staff";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2170;
    }

    class _3004 : IItem
    {
        public override int BaseGold => 775;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3070(), new _1037() };
        public override int Id => 3004;
        public override IEnumerable<int> Maps => new[] { 10, 11, 12 };
        public override string Name => "Manamune";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1680;
    }

    class _3006 : IItem
    {
        public override int BaseGold => 500;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1001(), new _1042() };
        public override int Id => 3006;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Berserker's Greaves";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 770;
    }

    class _3007 : IItem
    {
        public override int BaseGold => 1100;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3073(), new _1058() };
        public override int Id => 3007;
        public override IEnumerable<int> Maps => new[] { 8, 11 };
        public override string Name => "Archangel's Staff (Quick Charge)";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2170;
    }

    class _3008 : IItem
    {
        public override int BaseGold => 775;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3073(), new _1037() };
        public override int Id => 3008;
        public override IEnumerable<int> Maps => new[] { 8, 11 };
        public override string Name => "Manamune (Quick Charge)";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1680;
    }

    class _3009 : IItem
    {
        public override int BaseGold => 600;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1001() };
        public override int Id => 3009;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Boots of Swiftness";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 630;
    }

    class _3010 : IItem
    {
        public override int BaseGold => 350;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1028(), new _1027() };
        public override int Id => 3010;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Catalyst of Aeons";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 770;
    }

    class _3020 : IItem
    {
        public override int BaseGold => 800;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1001() };
        public override int Id => 3020;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Sorcerer's Shoes";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 770;
    }

    class _3022 : IItem
    {
        public override int BaseGold => 900;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3052(), new _1011() };
        public override int Id => 3022;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Frozen Mallet";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2170;
    }

    class _3024 : IItem
    {
        public override int BaseGold => 350;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1027(), new _1029() };
        public override int Id => 3024;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Glacial Shroud";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 700;
    }

    class _3025 : IItem
    {
        public override int BaseGold => 650;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3057(), new _3024() };
        public override int Id => 3025;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Iceborn Gauntlet";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1890;
    }

    class _3026 : IItem
    {
        public override int BaseGold => 880;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1057(), new _1031() };
        public override int Id => 3026;
        public override IEnumerable<int> Maps => new[] { 8, 11, 12 };
        public override string Name => "Guardian Angel";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 960;
    }

    class _3027 : IItem
    {
        public override int BaseGold => 750;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3010(), new _1026() };
        public override int Id => 3027;
        public override IEnumerable<int> Maps => new[] { 10, 11, 12 };
        public override string Name => "Rod of Ages";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1890;
    }

    class _3028 : IItem
    {
        public override int BaseGold => 100;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1004(), new _1033(), new _1004() };
        public override int Id => 3028;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Chalice of Harmony";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 560;
    }

    class _3029 : IItem
    {
        public override int BaseGold => 750;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3010(), new _1026() };
        public override int Id => 3029;
        public override IEnumerable<int> Maps => new[] { 8, 11 };
        public override string Name => "Rod of Ages (Quick Charge)";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1890;
    }

    class _3030 : IItem
    {
        public override int BaseGold => 850;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3010(), new _3145() };
        public override int Id => 3030;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Hextech GLP-800";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2100;
    }

    class _3031 : IItem
    {
        public override int BaseGold => 625;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1038(), new _1037(), new _1018() };
        public override int Id => 3031;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Infinity Edge";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2520;
    }

    class _3033 : IItem
    {
        public override int BaseGold => 600;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3035(), new _3123() };
        public override int Id => 3033;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Mortal Reminder";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1890;
    }

    class _3034 : IItem
    {
        public override int BaseGold => 650;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1036() };
        public override int Id => 3034;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Giant Slayer";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 700;
    }

    class _3035 : IItem
    {
        public override int BaseGold => 425;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1037() };
        public override int Id => 3035;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Last Whisper";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 910;
    }

    class _3036 : IItem
    {
        public override int BaseGold => 400;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3035(), new _3034() };
        public override int Id => 3036;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Lord Dominik's Regards";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1890;
    }

    class _3040 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3040;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Seraph's Embrace";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3041 : IItem
    {
        public override int BaseGold => 1050;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1082() };
        public override int Id => 3041;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Mejai's Soulstealer";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 980;
    }

    class _3042 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3042;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Muramana";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3043 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3043;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Muramana";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3044 : IItem
    {
        public override int BaseGold => 500;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1028(), new _1036() };
        public override int Id => 3044;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Phage";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 875;
    }

    class _3046 : IItem
    {
        public override int BaseGold => 650;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1042(), new _3086(), new _1042() };
        public override int Id => 3046;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Phantom Dancer";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1785;
    }

    class _3047 : IItem
    {
        public override int BaseGold => 500;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1001(), new _1029() };
        public override int Id => 3047;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Ninja Tabi";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 770;
    }

    class _3048 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3048;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Seraph's Embrace";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3050 : IItem
    {
        public override int BaseGold => 380;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1052(), new _3024(), new _1052() };
        public override int Id => 3050;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Zeke's Harbinger";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1575;
    }

    class _3052 : IItem
    {
        public override int BaseGold => 450;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1036(), new _1028() };
        public override int Id => 3052;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Jaurim's Fist";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 840;
    }

    class _3053 : IItem
    {
        public override int BaseGold => 1050;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3052(), new _1036() };
        public override int Id => 3053;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Sterak's Gage";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1820;
    }

    class _3056 : IItem
    {
        public override int BaseGold => 650;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _2053(), new _3067() };
        public override int Id => 3056;
        public override IEnumerable<int> Maps => new[] { 11, 12 };
        public override string Name => "Ohmwrecker";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1855;
    }

    class _3057 : IItem
    {
        public override int BaseGold => 700;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1027() };
        public override int Id => 3057;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Sheen";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 735;
    }

    class _3060 : IItem
    {
        public override int BaseGold => 100;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3105(), new _3024() };
        public override int Id => 3060;
        public override IEnumerable<int> Maps => new[] { 10, 11, 12 };
        public override string Name => "Banner of Command";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1540;
    }

    class _3065 : IItem
    {
        public override int BaseGold => 800;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3211(), new _3067() };
        public override int Id => 3065;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Spirit Visage";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1960;
    }

    class _3067 : IItem
    {
        public override int BaseGold => 400;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1028() };
        public override int Id => 3067;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Kindlegem";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 560;
    }

    class _3068 : IItem
    {
        public override int BaseGold => 1000;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1031(), new _3751() };
        public override int Id => 3068;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Sunfire Cape";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2030;
    }

    class _3069 : IItem
    {
        public override int BaseGold => 350;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3096(), new _2053() };
        public override int Id => 3069;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Talisman of Ascension";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 960;
    }

    class _3070 : IItem
    {
        public override int BaseGold => 275;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1027(), new _1004() };
        public override int Id => 3070;
        public override IEnumerable<int> Maps => new[] { 10, 11, 12 };
        public override string Name => "Tear of the Goddess";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 525;
    }

    class _3071 : IItem
    {
        public override int BaseGold => 750;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3044(), new _3133() };
        public override int Id => 3071;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "The Black Cleaver";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2170;
    }

    class _3072 : IItem
    {
        public override int BaseGold => 1150;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1038(), new _1036(), new _1053() };
        public override int Id => 3072;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "The Bloodthirster";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2590;
    }

    class _3073 : IItem
    {
        public override int BaseGold => 275;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1027(), new _1004() };
        public override int Id => 3073;
        public override IEnumerable<int> Maps => new[] { 8, 11 };
        public override string Name => "Tear of the Goddess (Quick Charge)";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 525;
    }

    class _3074 : IItem
    {
        public override int BaseGold => 525;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3077(), new _1053(), new _1037() };
        public override int Id => 3074;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Ravenous Hydra";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2450;
    }

    class _3075 : IItem
    {
        public override int BaseGold => 1250;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1029(), new _1031() };
        public override int Id => 3075;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Thornmail";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1645;
    }

    class _3077 : IItem
    {
        public override int BaseGold => 350;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1036(), new _1006(), new _1036() };
        public override int Id => 3077;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Tiamat";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 840;
    }

    class _3078 : IItem
    {
        public override int BaseGold => 333;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3101(), new _3057(), new _3044() };
        public override int Id => 3078;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Trinity Force";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2613;
    }

    class _3082 : IItem
    {
        public override int BaseGold => 400;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1029(), new _1029() };
        public override int Id => 3082;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Warden's Mail";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 700;
    }

    class _3083 : IItem
    {
        public override int BaseGold => 400;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1011(), new _3067(), new _3801() };
        public override int Id => 3083;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Warmog's Armor";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1995;
    }

    class _3084 : IItem
    {
        public override int BaseGold => 900;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1011(), new _3801() };
        public override int Id => 3084;
        public override IEnumerable<int> Maps => new int[] { };
        public override string Name => "Overlord's Bloodmail";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1785;
    }

    class _3085 : IItem
    {
        public override int BaseGold => 300;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1043(), new _3086() };
        public override int Id => 3085;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Runaan's Hurricane";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1820;
    }

    class _3086 : IItem
    {
        public override int BaseGold => 600;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1051(), new _1042() };
        public override int Id => 3086;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Zeal";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 910;
    }

    class _3087 : IItem
    {
        public override int BaseGold => 550;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3086(), new _2015() };
        public override int Id => 3087;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Statikk Shiv";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1820;
    }

    class _3089 : IItem
    {
        public override int BaseGold => 1265;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1026(), new _1058(), new _1052() };
        public override int Id => 3089;
        public override IEnumerable<int> Maps => new[] { 8, 11, 12 };
        public override string Name => "Rabadon's Deathcap";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2660;
    }

    class _3090 : IItem
    {
        public override int BaseGold => 1050;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3191(), new _1058() };
        public override int Id => 3090;
        public override IEnumerable<int> Maps => new[] { 8, 10 };
        public override string Name => "Wooglet's Witchcap";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2450;
    }

    class _3091 : IItem
    {
        public override int BaseGold => 480;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1043(), new _1057(), new _1042() };
        public override int Id => 3091;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Wit's End";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1750;
    }

    class _3092 : IItem
    {
        public override int BaseGold => 450;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3098(), new _3108() };
        public override int Id => 3092;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Frost Queen's Claim";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 880;
    }

    class _3094 : IItem
    {
        public override int BaseGold => 550;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3086(), new _2015() };
        public override int Id => 3094;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Rapid Firecannon";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1820;
    }

    class _3096 : IItem
    {
        public override int BaseGold => 375;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1004(), new _3301() };
        public override int Id => 3096;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Nomad's Medallion";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 340;
    }

    class _3097 : IItem
    {
        public override int BaseGold => 350;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3302(), new _1006() };
        public override int Id => 3097;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Targon's Brace";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 340;
    }

    class _3098 : IItem
    {
        public override int BaseGold => 375;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3303(), new _1004() };
        public override int Id => 3098;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Frostfang";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 340;
    }

    class _3100 : IItem
    {
        public override int BaseGold => 450;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3057(), new _3113(), new _1026() };
        public override int Id => 3100;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Lich Bane";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2240;
    }

    class _3101 : IItem
    {
        public override int BaseGold => 500;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1042(), new _1042() };
        public override int Id => 3101;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Stinger";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 770;
    }

    class _3102 : IItem
    {
        public override int BaseGold => 530;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3211(), new _1057() };
        public override int Id => 3102;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Banshee's Veil";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1715;
    }

    class _3104 : IItem
    {
        public override int BaseGold => 700;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3133(), new _3052() };
        public override int Id => 3104;
        public override IEnumerable<int> Maps => new[] { 10 };
        public override string Name => "Lord Van Damm's Pillager";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2100;
    }

    class _3105 : IItem
    {
        public override int BaseGold => 350;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1033(), new _1029() };
        public override int Id => 3105;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Aegis of the Legion";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 770;
    }

    class _3107 : IItem
    {
        public override int BaseGold => 650;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3114(), new _3801() };
        public override int Id => 3107;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Redemption";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1470;
    }

    class _3108 : IItem
    {
        public override int BaseGold => 465;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1052() };
        public override int Id => 3108;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Fiendish Codex";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 630;
    }

    class _3109 : IItem
    {
        public override int BaseGold => 700;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3801(), new _1029(), new _3801() };
        public override int Id => 3109;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Knight's Vow";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1610;
    }

    class _3110 : IItem
    {
        public override int BaseGold => 700;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3082(), new _3024() };
        public override int Id => 3110;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Frozen Heart";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1890;
    }

    class _3111 : IItem
    {
        public override int BaseGold => 350;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1001(), new _1033() };
        public override int Id => 3111;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Mercury's Treads";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 770;
    }

    class _3112 : IItem
    {
        public override int BaseGold => 950;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3112;
        public override IEnumerable<int> Maps => new[] { 12 };
        public override string Name => "Guardian's Orb";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 380;
    }

    class _3113 : IItem
    {
        public override int BaseGold => 415;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1052() };
        public override int Id => 3113;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Aether Wisp";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 595;
    }

    class _3114 : IItem
    {
        public override int BaseGold => 550;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1004(), new _1004() };
        public override int Id => 3114;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Forbidden Idol";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 560;
    }

    class _3115 : IItem
    {
        public override int BaseGold => 1000;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3101(), new _3108() };
        public override int Id => 3115;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Nashor's Tooth";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2100;
    }

    class _3116 : IItem
    {
        public override int BaseGold => 915;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1026(), new _1052(), new _1028() };
        public override int Id => 3116;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Rylai's Crystal Scepter";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1820;
    }

    class _3117 : IItem
    {
        public override int BaseGold => 600;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1001() };
        public override int Id => 3117;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Boots of Mobility";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 630;
    }

    class _3122 : IItem
    {
        public override int BaseGold => 450;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1051(), new _1036() };
        public override int Id => 3122;
        public override IEnumerable<int> Maps => new[] { 8 };
        public override string Name => "Wicked Hatchet";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 840;
    }

    class _3123 : IItem
    {
        public override int BaseGold => 450;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1036() };
        public override int Id => 3123;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Executioner's Calling";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 560;
    }

    class _3124 : IItem
    {
        public override int BaseGold => 875;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1026(), new _1043(), new _1037() };
        public override int Id => 3124;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Guinsoo's Rageblade";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2520;
    }

    class _3133 : IItem 
    {
        public override int BaseGold => 400;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1036(), new _1036() };
        public override int Id => 3133;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Caulfield's Warhammer";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 770;
    }

    class _3134 : IItem
    {
        public override int BaseGold => 400;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1036(), new _1036() };
        public override int Id => 3134;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Serrated Dirk";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 770;
    }

    class _3135 : IItem
    {
        public override int BaseGold => 1365;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1026(), new _1052() };
        public override int Id => 3135;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Void Staff";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1855;
    }

    class _3136 : IItem
    {
        public override int BaseGold => 665;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1028(), new _1052() };
        public override int Id => 3136;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Haunting Guise";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1050;
    }

    class _3137 : IItem
    {
        public override int BaseGold => 300;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3140(), new _3101() };
        public override int Id => 3137;
        public override IEnumerable<int> Maps => new int[] { };
        public override string Name => "Dervish Blade";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1890;
    }

    class _3139 : IItem
    {
        public override int BaseGold => 525;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3140(), new _1037(), new _1053() };
        public override int Id => 3139;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Mercurial Scimitar";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2520;
    }

    class _3140 : IItem
    {
        public override int BaseGold => 850;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1033() };
        public override int Id => 3140;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Quicksilver Sash";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 910;
    }

    class _3142 : IItem
    {
        public override int BaseGold => 700;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3133(), new _3134() };
        public override int Id => 3142;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Youmuu's Ghostblade";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2030;
    }

    class _3143 : IItem
    {
        public override int BaseGold => 900;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3082(), new _1011() };
        public override int Id => 3143;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Randuin's Omen";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2030;
    }

    class _3144 : IItem
    {
        public override int BaseGold => 250;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1053(), new _1036() };
        public override int Id => 3144;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Bilgewater Cutlass";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1050;
    }

    class _3145 : IItem
    {
        public override int BaseGold => 180;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1052(), new _1052() };
        public override int Id => 3145;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Hextech Revolver";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 735;
    }

    class _3146 : IItem
    {
        public override int BaseGold => 850;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3144(), new _3145() };
        public override int Id => 3146;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Hextech Gunblade";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2380;
    }

    class _3147 : IItem
    {
        public override int BaseGold => 850;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3134(), new _1038() };
        public override int Id => 3147;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Duskblade of Draktharr";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2275;
    }

    class _3151 : IItem
    {
        public override int BaseGold => 750;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3136(), new _1026() };
        public override int Id => 3151;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Liandry's Torment";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2170;
    }

    class _3152 : IItem
    {
        public override int BaseGold => 650;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3145(), new _3067() };
        public override int Id => 3152;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Hextech Protobelt-01";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1750;
    }

    class _3153 : IItem
    {
        public override int BaseGold => 900;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3144(), new _1043() };
        public override int Id => 3153;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Blade of the Ruined King";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2380;
    }

    class _3155 : IItem
    {
        public override int BaseGold => 500;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1036(), new _1033() };
        public override int Id => 3155;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Hexdrinker";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 910;
    }

    class _3156 : IItem
    {
        public override int BaseGold => 850;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3155(), new _3133() };
        public override int Id => 3156;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Maw of Malmortius";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2275;
    }

    class _3157 : IItem
    {
        public override int BaseGold => 800;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3191(), new _3108() };
        public override int Id => 3157;
        public override IEnumerable<int> Maps => new[] { 8, 11, 12 };
        public override string Name => "Zhonya's Hourglass";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2030;
    }

    class _3158 : IItem
    {
        public override int BaseGold => 600;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1001() };
        public override int Id => 3158;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Ionian Boots of Lucidity";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 630;
    }

    class _3165 : IItem
    {
        public override int BaseGold => 665;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3108(), new _1052(), new _3802() };
        public override int Id => 3165;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Morellonomicon";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2030;
    }

    class _3170 : IItem
    {
        public override int BaseGold => 580;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3191(), new _1057() };
        public override int Id => 3170;
        public override IEnumerable<int> Maps => new[] { 8, 10 };
        public override string Name => "Moonflair Spellblade";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1750;
    }

    class _3174 : IItem
    {
        public override int BaseGold => 400;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3108(), new _3028() };
        public override int Id => 3174;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Athene's Unholy Grail";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1470;
    }

    class _3175 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3175;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Head of Kha'Zix";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new[] { Champion.Rengar };
        public override int SellGold => 0;
    }

    class _3181 : IItem
    {
        public override int BaseGold => 625;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1037(), new _1053() };
        public override int Id => 3181;
        public override IEnumerable<int> Maps => new int[] { };
        public override string Name => "Sanguine Blade";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1680;
    }

    class _3184 : IItem
    {
        public override int BaseGold => 950;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3184;
        public override IEnumerable<int> Maps => new[] { 12 };
        public override string Name => "Guardian's Hammer";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 380;
    }

    class _3185 : IItem
    {
        public override int BaseGold => 350;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3122(), new _1018() };
        public override int Id => 3185;
        public override IEnumerable<int> Maps => new[] { 8 };
        public override string Name => "The Lightbringer";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1645;
    }

    class _3187 : IItem
    {
        public override int BaseGold => 350;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3024(), new _3067() };
        public override int Id => 3187;
        public override IEnumerable<int> Maps => new[] { 8 };
        public override string Name => "Arcane Sweeper";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1505;
    }

    class _3190 : IItem
    {
        public override int BaseGold => 650;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3105(), new _1033() };
        public override int Id => 3190;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Locket of the Iron Solari";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1540;
    }

    class _3191 : IItem
    {
        public override int BaseGold => 165;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1029(), new _1052(), new _1029() };
        public override int Id => 3191;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Seeker's Armguard";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 840;
    }

    class _3196 : IItem
    {
        public override int BaseGold => 1250;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3200() };
        public override int Id => 3196;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "The Hex Core mk-1";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new[] { Champion.Viktor };
        public override int SellGold => 875;
    }

    class _3197 : IItem
    {
        public override int BaseGold => 1000;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3196() };
        public override int Id => 3197;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "The Hex Core mk-2";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new[] { Champion.Viktor };
        public override int SellGold => 1575;
    }

    class _3198 : IItem
    {
        public override int BaseGold => 750;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3197() };
        public override int Id => 3198;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Perfect Hex Core";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new[] { Champion.Viktor };
        public override int SellGold => 2100;
    }

    class _3200 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3200;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Prototype Hex Core";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new[] { Champion.Viktor };
        public override int SellGold => 0;
    }

    class _3211 : IItem
    {
        public override int BaseGold => 350;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1028(), new _1033() };
        public override int Id => 3211;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Spectre's Cowl";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 840;
    }

    class _3222 : IItem
    {
        public override int BaseGold => 500;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3028(), new _3114() };
        public override int Id => 3222;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Mikael's Crucible";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1470;
    }

    class _3252 : IItem
    {
        public override int BaseGold => 400;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1036() };
        public override int Id => 3252;
        public override IEnumerable<int> Maps => new[] { 10, 11 };
        public override string Name => "Poacher's Dirk";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 525;
    }

    class _3285 : IItem
    {
        public override int BaseGold => 1100;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1058(), new _3113() };
        public override int Id => 3285;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Luden's Echo";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2240;
    }

    class _3301 : IItem
    {
        public override int BaseGold => 350;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3301;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Ancient Coin";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 140;
    }

    class _3302 : IItem
    {
        public override int BaseGold => 350;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3302;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Relic Shield";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 140;
    }

    class _3303 : IItem
    {
        public override int BaseGold => 350;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3303;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Spellthief's Edge";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 140;
    }

    class _3340 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3340;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Warding Totem (Trinket)";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3341 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3341;
        public override IEnumerable<int> Maps => new[] { 11, 12 };
        public override string Name => "Sweeping Lens (Trinket)";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3345 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3345;
        public override IEnumerable<int> Maps => new[] { 8 };
        public override string Name => "Soul Anchor (Trinket)";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3348 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3348;
        public override IEnumerable<int> Maps => new[] { 8, 10 };
        public override string Name => "Arcane Sweeper";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3361 : IItem
    {
        public override int BaseGold => 250;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3361;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Greater Stealth Totem (Trinket)";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 175;
    }

    class _3362 : IItem
    {
        public override int BaseGold => 250;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3362;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Greater Vision Totem (Trinket)";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 175;
    }

    class _3363 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3363;
        public override IEnumerable<int> Maps => new[] { 11, 12 };
        public override string Name => "Farsight Alteration";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3364 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3364;
        public override IEnumerable<int> Maps => new[] { 11, 12 };
        public override string Name => "Oracle Alteration";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3401 : IItem
    {
        public override int BaseGold => 550;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3097(), new _3067() };
        public override int Id => 3401;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Face of the Mountain";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 880;
    }

    class _3410 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3410;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Head of Kha'Zix";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new[] { Champion.Rengar };
        public override int SellGold => 0;
    }

    class _3416 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3416;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Head of Kha'Zix";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new[] { Champion.Rengar };
        public override int SellGold => 0;
    }

    class _3422 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3422;
        public override IEnumerable<int> Maps => new[] { 8, 10, 12 };
        public override string Name => "Head of Kha'Zix";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new[] { Champion.Rengar };
        public override int SellGold => 0;
    }

    class _3455 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3455;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Head of Kha'Zix";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new[] { Champion.Rengar };
        public override int SellGold => 0;
    }

    class _3460 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3460;
        public override IEnumerable<int> Maps => new[] { 8 };
        public override string Name => "Golden Transcendence";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3461 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3461;
        public override IEnumerable<int> Maps => new[] { 8 };
        public override string Name => "Golden Transcendence (Disabled)";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3462 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3462;
        public override IEnumerable<int> Maps => new[] { 8 };
        public override string Name => "Seer Stone (Trinket)";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3504 : IItem
    {
        public override int BaseGold => 650;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3114(), new _3113() };
        public override int Id => 3504;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Ardent Censer";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1610;
    }

    class _3508 : IItem
    {
        public override int BaseGold => 400;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1038(), new _3133(), new _1018() };
        public override int Id => 3508;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Essence Reaver";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2520;
    }

    class _3512 : IItem
    {
        public override int BaseGold => 780;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _2053(), new _1057() };
        public override int Id => 3512;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Zz'Rot Portal";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1890;
    }

    class _3599 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3599;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "The Black Spear";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new[] { Champion.Kalista };
        public override int SellGold => 0;
    }

    class _3630 : IItem
    {
        public override int BaseGold => 10;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3630;
        public override IEnumerable<int> Maps => new int[] { };
        public override string Name => "Siege Teleport";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 7;
    }

    class _3631 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3631;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Siege Ballista";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3632 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3632;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3633 : IItem
    {
        public override int BaseGold => 10;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3633;
        public override IEnumerable<int> Maps => new int[] { };
        public override string Name => "Siege Teleport";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 7;
    }

    class _3634 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3634;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Tower: Beam of Ruination";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3635 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3635;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Port Pad";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3636 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3636;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Tower: Storm Bulwark";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3637 : IItem
    {
        public override int BaseGold => 10;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3637;
        public override IEnumerable<int> Maps => new int[] { };
        public override string Name => "Nexus Siege: Siege Weapon Slot";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 7;
    }

    class _3640 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3640;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Flash Zone";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3641 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3641;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Vanguard Banner";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3642 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3642;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Siege Refund";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3643 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3643;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Entropy Field";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3645 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3645;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Seer Stone (Trinket)";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3647 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3647;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Shield Totem";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3648 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3648;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Siege Teleport (Inactive)";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3649 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3649;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Siege Sight Warder";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3671 : IItem
    {
        public override int BaseGold => 525;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3133() };
        public override int Id => 3671;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Enchantment: Warrior";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1138;
    }

    class _3672 : IItem
    {
        public override int BaseGold => 525;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3751() };
        public override int Id => 3672;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Enchantment: Cinderhulk";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1138;
    }

    class _3673 : IItem
    {
        public override int BaseGold => 340;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3113(), new _1052() };
        public override int Id => 3673;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Enchantment: Runic Echoes";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1138;
    }

    class _3675 : IItem
    {
        public override int BaseGold => 625;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1043() };
        public override int Id => 3675;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Enchantment: Bloodrazor";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1138;
    }

    class _3680 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3680;
        public override IEnumerable<int> Maps => new[] { 12 };
        public override string Name => "Frosted Snax";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3681 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3681;
        public override IEnumerable<int> Maps => new[] { 12 };
        public override string Name => "Super Spicy Snax";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3682 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3682;
        public override IEnumerable<int> Maps => new[] { 12 };
        public override string Name => "Espresso Snax";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3683 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3683;
        public override IEnumerable<int> Maps => new[] { 12 };
        public override string Name => "Rainbow Snax Party Pack!";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 0;
    }

    class _3706 : IItem
    {
        public override int BaseGold => 300;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1039(), new _1041() };
        public override int Id => 3706;
        public override IEnumerable<int> Maps => new[] { 10, 11 };
        public override string Name => "Stalker's Blade";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 700;
    }

    class _3711 : IItem
    {
        public override int BaseGold => 300;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1039(), new _1041() };
        public override int Id => 3711;
        public override IEnumerable<int> Maps => new[] { 11 };
        public override string Name => "Tracker's Knife";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 700;
    }

    class _3715 : IItem
    {
        public override int BaseGold => 300;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1039(), new _1041() };
        public override int Id => 3715;
        public override IEnumerable<int> Maps => new[] { 10, 11 };
        public override string Name => "Skirmisher's Sabre";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 700;
    }

    class _3742 : IItem
    {
        public override int BaseGold => 1100;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1031(), new _1011() };
        public override int Id => 3742;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Dead Man's Plate";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2030;
    }

    class _3748 : IItem
    {
        public override int BaseGold => 700;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3077(), new _1028(), new _3052() };
        public override int Id => 3748;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Titanic Hydra";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2450;
    }

    class _3751 : IItem
    {
        public override int BaseGold => 700;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1028() };
        public override int Id => 3751;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Bami's Cinder";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 770;
    }

    class _3800 : IItem
    {
        public override int BaseGold => 750;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _3010(), new _3801() };
        public override int Id => 3800;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Righteous Glory";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 1750;
    }

    class _3801 : IItem
    {
        public override int BaseGold => 100;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1028(), new _1006() };
        public override int Id => 3801;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Crystalline Bracer";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 455;
    }

    class _3802 : IItem
    {
        public override int BaseGold => 115;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1052(), new _1027() };
        public override int Id => 3802;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Lost Chapter";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 630;
    }

    class _3812 : IItem
    {
        public override int BaseGold => 625;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1053(), new _1037(), new _3133() };
        public override int Id => 3812;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Death's Dance";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2450;
    }

    class _3814 : IItem
    {
        public override int BaseGold => 675;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { new _1037(), new _3134(), new _1033() };
        public override int Id => 3814;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Edge of Night";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new Champion[] { };
        public override int SellGold => 2170;
    }

    class _3901 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3901;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Fire at Will";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new[] { Champion.Gangplank };
        public override int SellGold => 0;
    }

    class _3902 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3902;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Death's Daughter";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new[] { Champion.Gangplank };
        public override int SellGold => 0;
    }

    class _3903 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[] { };
        public override int Id => 3903;
        public override IEnumerable<int> Maps => new[] { 8, 10, 11, 12 };
        public override string Name => "Raise Morale";
        public override bool Purchaseable => true;
        public override IEnumerable<Champion> RequiredChampions => new[] { Champion.Gangplank };
        public override int SellGold => 0;
    }

    class _1000 : IItem
    {
        public override int BaseGold => 0;
        public override IEnumerable<IItem> BuiltFrom => new IItem[0];
        public override int Id => 1000;
        public override IEnumerable<int> Maps => new int[0];
        public override string Name => "Unexisting item defaults to here.";
        public override bool Purchaseable => false;
        public override IEnumerable<Champion> RequiredChampions => new Champion[0];
        public override int SellGold => 0;
    }

    static class Items
    {
        public static IItem GetItemById(int id)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in types.Where(x => x.IsSubclassOf(typeof(IItem))))
            {
                var obj = Activator.CreateInstance(type) as IItem;
                if (obj != null && obj.Id.Equals(id))
                {
                    return obj;
                }
            }
            return null;
        }
    }
}