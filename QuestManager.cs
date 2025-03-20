using UnityEngine;

namespace GameCore
{
    public class QuestManager : MonoBehaviour
    {
        public QuestData[] quests;

        public void StartQuest(int questId)
        {
            foreach (var quest in quests)
            {
                if (quest.questId == questId)
                {
                    Debug.Log($"Started quest: {quest.questName}");
                    break;
                }
            }
        }
    }
}