using BurningKnight.PanelManager;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Scripts
{
    public class PausePanel : PanelBase
    {
        [SerializeField] private Button _mainMenuButton;
        [SerializeField] private Button _continueButton;
        [SerializeField] private ToggleSettings _soundToggle;
        [SerializeField] private ToggleSettings _sfxToggle;

        public override void Init()
        {
            var temp = false;
            _soundToggle.Init(temp, OnSound, OffSound);
            _sfxToggle.Init(temp, OnSFX, OffSFX);
        }

        protected override void OnOpened()
        {
            _mainMenuButton.onClick.AddListener(OnMainMenu);
            _continueButton.onClick.AddListener(OnContinue);
        }

        protected override void OnClosed()
        {
            _mainMenuButton.onClick.RemoveListener(OnMainMenu);
            _continueButton.onClick.RemoveListener(OnContinue);
        }

        private void OnSound()
        {
        }

        private void OffSound()
        {
        }

        private void OnSFX()
        {
        }

        private void OffSFX()
        {
        }

        private void OnContinue()
        {
            Close();
        }

        private void OnMainMenu()
        {
        }
    }
}