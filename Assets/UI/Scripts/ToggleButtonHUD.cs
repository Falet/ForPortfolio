using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Scripts
{
    public class ToggleButtonHUD : MonoBehaviour
    {
        [SerializeField] private GameObject _inactiveToggleButton;
        [SerializeField] private Image _imagePressed;
        [SerializeField] private Sprite _iconPressed;
        [SerializeField] private Image _imageUnpressed;
        [SerializeField] private Sprite _iconUnpressed;
        [SerializeField] private Toggle _toggle;

        private void Awake()
        {
            _imagePressed.sprite = _iconPressed;
            _imageUnpressed.sprite = _iconUnpressed;
        }

        public void InitButton(Action action, bool isActivate)
        {
            _toggle.onValueChanged.AddListener(delegate(bool isOn) { PressButton(isOn, action); });
            _toggle.isOn = isActivate;
        }

        private void PressButton(bool isOn, Action action)
        {
            if (isOn)
                action?.Invoke();
            Change(isOn);
        }

        private void Change(bool isOns)
        {
            _inactiveToggleButton.SetActive(!isOns);
        }
    }
}