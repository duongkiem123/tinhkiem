namespace GameItems
{
    [System.Serializable]
    public class Sword
    {
        public int id;
        public string SwordName;
        public int price;
        public int baseAttribute28Min;
        public int baseAttribute28Max;
        public int baseAttribute29Min;
        public int baseAttribute29Max;
        public int requiredAttribute31;
        public string description;

        public Sword(int id, string swordName, int price, int attr28Min, int attr28Max, int attr29Min, int attr29Max, int reqAttr31, string description)
        {
            this.id = id;
            this.SwordName = swordName; // Sửa lỗi
            this.price = price;
            this.baseAttribute28Min = attr28Min;
            this.baseAttribute28Max = attr28Max;
            this.baseAttribute29Min = attr29Min;
            this.baseAttribute29Max = attr29Max;
            this.requiredAttribute31 = reqAttr31;
            this.description = description;
        }
    }
}