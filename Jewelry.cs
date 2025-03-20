namespace GameItems
{
    [System.Serializable]
    public class Jewelry : Item
    {
        public string JewelryName;
        public JewelryType jewelryType;
        public float resistanceBonus;

        public Jewelry(int id, string jewelryName, int price, JewelryType jewelryType, float resistanceBonus, string description, ItemRarity rarity)
            : base(id, price, description, rarity)
        {
            this.JewelryName = jewelryName;
            this.jewelryType = jewelryType;
            this.resistanceBonus = resistanceBonus;
        }

        public override string GetName() => JewelryName;
        public override ItemType GetItemType() => ItemType.Jewelry;

        public enum JewelryType
        {
            Ring,      // Nhẫn
            Necklace,  // Dây chuyền
            Pendant    // Bội
        }
    }
}