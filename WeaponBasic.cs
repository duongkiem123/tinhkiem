namespace GameItems
{
    [System.Serializable]
    public class WeaponBasic : Item
    {
        public string WeaponName;
        public WeaponType weaponType;
        public int baseAttackMin;
        public int baseAttackMax;
        public int requiredLevel;

        public WeaponBasic(int id, string weaponName, int price, WeaponType weaponType, int baseAttackMin, int baseAttackMax, int requiredLevel, string description, ItemRarity rarity)
            : base(id, price, description, rarity)
        {
            this.WeaponName = weaponName;
            this.weaponType = weaponType;
            this.baseAttackMin = baseAttackMin;
            this.baseAttackMax = baseAttackMax;
            this.requiredLevel = requiredLevel;
        }

        public override string GetName() => WeaponName;
        public override ItemType GetItemType() => ItemType.Weapon;

        public enum WeaponType
        {
            Sword,
            Knife,
            Staff,
            Bow,
            Mace,
            Flute,
            Poison
        }
    }
}
