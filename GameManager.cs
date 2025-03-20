using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameCore
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }
        public Player player;
        public Inventory inventory;
        public DatabaseManager dbManager;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        void Start()
        {
            dbManager = FindObjectOfType<DatabaseManager>();
            if (dbManager == null) Debug.LogError("DatabaseManager not found!");
            inventory = new Inventory();
        }

        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}