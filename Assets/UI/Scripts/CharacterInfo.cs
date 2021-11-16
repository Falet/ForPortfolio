using System;
using TMPro;
using UnityEngine;

namespace UI.Scripts
{
    public class CharacterInfo : MonoBehaviour
    {
        [SerializeField] private TMP_Text _textAmountMoney;
        [SerializeField] private TMP_Text _textLevelCharacter;

        private int amountMoney { get; set; }

        public void UpdateMoneyInfo(int value)
        {
            if (value >= 1000)
            {
                var count = (float)value / 1000;
                var roundCount = Math.Round(count, 1);
                _textAmountMoney.text = $"{roundCount:F1}K";
            }
            else
            {
                _textAmountMoney.text = $"{amountMoney}";
            }
        }

        public void UpdateLevelInfo(int value)
        {
            _textLevelCharacter.text = $"LEVEL {value}";
        }
    }
}
