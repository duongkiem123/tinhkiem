using UnityEngine;

namespace GameCore
{
    public class Player : MonoBehaviour
    {
        public PlayerData data;
        public Weapon equippedWeapon;
        public Armor equippedArmor;

        void Start()
        {
            if (data == null) data = new PlayerData();
            GameManager.Instance.player = this;
        }

        public int CalculateAttackDamage()
        {
            int baseDamage = data.strength * 2;
            if (equippedWeapon != null)
            {
                baseDamage += equippedWeapon.damageBonus;
            }
            return baseDamage;
        }

        public void EquipItem(Item item)
        {
            if (item is Weapon)
            {
                equippedWeapon = (Weapon)item;
            }
            else if (item is Armor)
            {
                equippedArmor = (Armor)item;
            }
        }
    }
}