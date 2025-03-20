using UnityEngine;

namespace GameCore
{
    public enum Element { Kim, Moc, Thuy, Hoa, Tho }

    public class Item : MonoBehaviour
    {
        public string itemName;
        public int itemID;
        public Sprite itemIcon;
        public Element element;
    }
}