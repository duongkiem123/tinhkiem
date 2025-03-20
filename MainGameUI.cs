using UnityEngine;
using TMPro;

namespace GameCore
{
    public class MainGameUI : MonoBehaviour
    {
        public TMP_Text nameText, hpText, mpText, levelText;

        void Start()
        {
            UpdateUI();
        }

        public void UpdateUI()
        {
            PlayerData data = GameManager.Instance.player.data;
            nameText.text = $"Tên: {data.characterName}";
            hpText.text = $"HP: {data.currentHP}/{data.maxHP}";
            mpText.text = $"MP: {data.currentMP}/{data.maxMP}";
            levelText.text = $"Level: {data.level}";
        }
    }
}