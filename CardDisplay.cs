using UnityEngine;
using TMPro;
using GameItems;
using GameCards;

namespace GameUI
{
    public class CardDisplay : MonoBehaviour
    {
        public Card card;
        public TextMeshProUGUI nameText, attackText, healthText, manaText;

        void Start()
        {
            nameText.text = card.Name;
            attackText.text = card.Attack.ToString();
            healthText.text = card.Health.ToString();
            manaText.text = card.ManaCost.ToString();
        }
    }
}