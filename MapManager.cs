using UnityEngine;

namespace GameCore
{
    public class MapManager : MonoBehaviour
    {
        public void LoadMap(string mapName)
        {
            Debug.Log("Loaded map: " + mapName);
        }
    }
}