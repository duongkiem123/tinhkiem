using UnityEngine;

namespace GameCore
{
    public class BattleManager : MonoBehaviour
    {
        public Monster currentMonster;

        public void StartBattle(Player player, Monster monster)
        {
            currentMonster = monster;
            Debug.Log("Battle started with monster: " + monster.name);
        }

        public void PlayerAttack()
        {
            int damage = GameManager.Instance.player.CalculateAttackDamage();
            currentMonster.TakeDamage(damage);
            if (currentMonster.hp <= 0)
            {
                Debug.Log("Monster defeated!");
                GameManager.Instance.player.data.AddExp(50); // Cộng kinh nghiệm
                Item droppedItem = currentMonster.GetDroppedItem();
                if (droppedItem != null)
                {
                    GameManager.Instance.inventory.AddItem(droppedItem);
                }
            }
        }
    }

    // Lớp Monster để hỗ trợ BattleManager
    public class Monster : MonoBehaviour
    {
        public string name;
        public int hp;
        public Item[] possibleDrops;
        public float[] dropRates;

        public void TakeDamage(int damage)
        {
            hp -= damage;
            if (hp < 0) hp = 0;
        }

        public Item GetDroppedItem()
        {
            for (int i = 0; i < possibleDrops.Length; i++)
            {
                if (Random.value <= dropRates[i])
                {
                    return possibleDrops[i];
                }
            }
            return null;
        }
    }
}