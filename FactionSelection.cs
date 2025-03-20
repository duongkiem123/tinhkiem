using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameCore
{
    public class FactionSelection : MonoBehaviour
    {
        public void SelectFaction(int factionId)
        {
            PlayerPrefs.SetInt("Faction", factionId);
            GameManager.Instance.player.data.factionId = factionId;
            SceneManager.LoadScene("MainGame");
        }
    }
}