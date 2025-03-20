using UnityEngine;

namespace GameCards
{
    [System.Serializable]
    public class Card
    {
        public string Name;
        public string Element;
        public int Attack;
        public int Health;
        public int ManaCost;
        public string Ability;
        public bool IsAutoSkill;
        public int TriggerCondition;
        public int CurrentCooldown;
        public int Cooldown;
    }
}