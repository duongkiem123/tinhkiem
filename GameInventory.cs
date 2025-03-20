using UnityEngine;

namespace GameInventory
{
    public class GameInventoryManager : MonoBehaviour
    {
        public int totalSlots = 10; // Ví dụ

        private void Awake()
        {
            Debug.Log("Inventory khởi tạo!");
        }
    }
}