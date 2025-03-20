using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

namespace GameCore
{
    public class CharacterCreation : MonoBehaviour
    {
        public TMP_InputField nameInput;
        public Button maleButton, femaleButton;
        public Button[] factionButtons;

        private int selectedGender = -1;
        private int selectedFaction = -1;

        void Start()
        {
            maleButton.onClick.AddListener(() => SelectGender(0));
            femaleButton.onClick.AddListener(() => SelectGender(1));
            for (int i = 0; i < factionButtons.Length; i++)
            {
                int factionId = i;
                factionButtons[i].onClick.AddListener(() => SelectFaction(factionId));
            }
        }

        void SelectGender(int gender)
        {
            selectedGender = gender;
        }

        void SelectFaction(int factionId)
        {
            selectedFaction = factionId;
            string name = nameInput.text;
            if (!string.IsNullOrEmpty(name) && selectedGender != -1)
            {
                GameManager.Instance.dbManager.SaveCharacter("currentPlayerId", name, selectedGender, selectedFaction);
                GameManager.Instance.player.data.characterName = name;
                GameManager.Instance.player.data.gender = selectedGender;
                GameManager.Instance.player.data.factionId = selectedFaction;
                SceneManager.LoadScene("MainGame");
            }
        }
    }
}