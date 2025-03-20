using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

namespace GameCore
{
    public class LoginManager : MonoBehaviour
    {
        public TMP_InputField idInput, passwordInput;
        public Button loginButton, registerButton;

        void Start()
        {
            loginButton.onClick.AddListener(OnLoginClick);
            registerButton.onClick.AddListener(OnRegisterClick);
        }

        void OnLoginClick()
        {
            if (GameManager.Instance.dbManager.LoginPlayer(idInput.text, passwordInput.text))
            {
                SceneManager.LoadScene("MainGame");
            }
            else
            {
                Debug.LogWarning("Login failed!");
            }
        }

        void OnRegisterClick()
        {
            if (GameManager.Instance.dbManager.RegisterPlayer(idInput.text, passwordInput.text))
            {
                SceneManager.LoadScene("CharacterCreation");
            }
            else
            {
                Debug.LogWarning("Register failed!");
            }
        }
    }
}