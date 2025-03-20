using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameCore
{
    public class SceneTransition : MonoBehaviour
    {
        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}