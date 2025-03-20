namespace GameItems
{
    [System.Serializable]
    public class PhiPhong : Item
    {
        public string PhiPhongName;
        public int specialBonus; // Một chỉ số đặc biệt (ví dụ: tăng dame toàn phần)

        public PhiPhong(int id, string phiPhongName, int price, int specialBonus, string description, ItemRarity rarity)
            : base(id, price, description, rarity)
        {
            this.PhiPhongName = phiPhongName;
            this.specialBonus = specialBonus;
        }

        public override string GetName() => PhiPhongName;
        public override ItemType GetItemType() => ItemType.PhiPhong;
    }
}