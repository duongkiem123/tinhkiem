using UnityEngine;

namespace GameCore
{
    public class Inventory
    {
        public Item[] items = new Item[10];

        public void AddItem(Item item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    items[i] = item;
                    Debug.Log("Added item: " + item.itemName);
                    break;
                }
            }
        }

        public void RemoveItem(int index)
        {
            if (index >= 0 && index < items.Length)
            {
                items[index] = null;
                Debug.Log("Đã xóa vật phẩm tại vị trí: " + index);
            }
        }
    }
}