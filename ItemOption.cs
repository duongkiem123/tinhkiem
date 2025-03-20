using UnityEngine;

namespace GameItems
{
    [System.Serializable]
    public class ItemOption
    {
        public OptionType type;
        public float value;

        public ItemOption(OptionType type, float value)
        {
            this.type = type;
            this.value = value;
        }
    }

    public enum OptionType
    {
        SinhLuc,           // Tăng HP
        NoiLuc,           // Tăng MP
        KhangTatCa,       // Kháng tất cả
        ChinhXac,         // Chính xác
        NeTranh,          // Né tránh
        SatThuongChiMang, // Sát thương chí mạng
        SatThuongVatLy,   // Sát thương vật lý
        SatThuongPhepThuat, // Sát thương phép thuật
        HutSinhLuc        // Hút sinh lực
    }
}