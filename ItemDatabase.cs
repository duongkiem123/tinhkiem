using UnityEngine;

namespace GameCore
{
    public class ItemDatabase : MonoBehaviour
    {
        public Item[] items;

        public Item GetItemByID(int id)
        {
            foreach (Item item in items)
            {
                if (item.itemID == id) return item;
            }
            return null;
        }
    }
}