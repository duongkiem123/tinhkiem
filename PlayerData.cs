namespace GameCore
{
    [System.Serializable]
    public class PlayerData
    {
        public int currentHP;
        public int maxHP;
        public int currentMP;
        public int maxMP;
        public int level;
        public int exp;
        public int expToNextLevel;
        public int gender;
        public int factionId;
        public string characterName;
        public int potentialPoints;
        public int skillPoints;
        public int strength;
        public int agility;
        public int intelligence;

        public PlayerData()
        {
            currentHP = maxHP = 100;
            currentMP = maxMP = 50;
            level = 1;
            exp = 0;
            expToNextLevel = 100;
            gender = -1;
            factionId = -1;
            characterName = "";
            potentialPoints = 0;
            skillPoints = 0;
            strength = 10;
            agility = 10;
            intelligence = 10;
        }

        public void AddExp(int amount)
        {
            exp += amount;
            while (exp >= expToNextLevel)
            {
                LevelUp();
            }
        }

        private void LevelUp()
        {
            level++;
            exp -= expToNextLevel;
            expToNextLevel = (int)(100 * Mathf.Pow(1.1f, level));
            potentialPoints += 5;
            skillPoints += 1;
        }
    }
}