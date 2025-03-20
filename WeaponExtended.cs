namespace GameItems
{
    [System.Serializable]
    public class WeaponExtended : Item
    {
        public string WeaponName;
        public WeaponType weaponType;
        public int damage;
        public int durability;
        public int requiredLevel;

        public WeaponExtended(int id, string weaponName, int price, WeaponType weaponType, int damage, int durability, int requiredLevel, string description, ItemRarity rarity, ElementType elementType = ElementType.None)
            : base(id, price, description, rarity, elementType)
        {
            this.WeaponName = weaponName;
            this.weaponType = weaponType;
            this.damage = damage;
            this.durability = durability;
            this.requiredLevel = requiredLevel;
        }

        public override string GetName() => WeaponName;
        public override ItemType GetItemType() => ItemType.Weapon;

        public enum WeaponType
        {
            Sword,
            Axe,
            Bow,
            Staff,
            Dagger
        }
    }
}