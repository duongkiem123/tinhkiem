using UnityEngine;

namespace GameCore
{
    public class AutoManager : MonoBehaviour
    {
        public bool autoBattle;
        public bool autoLoot;

        void Update()
        {
            if (autoBattle)
            {
                Debug.Log("Auto battling...");
            }
            if (autoLoot)
            {
                Debug.Log("Auto looting...");
            }
        }
    }
}