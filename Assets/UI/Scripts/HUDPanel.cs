using BurningKnight.PanelManager;
using UnityEngine;

namespace UI.Scripts
{
    public class HUDPanel : PanelBase
    {
        [SerializeField] private ToggleButtonHUD _toggleButtonCharacter;
        [SerializeField] private ToggleButtonHUD _toggleButtonMap;
        [SerializeField] private ToggleButtonHUD _toggleButtonSettings;

        private void Start()
        {
            Init();
        }

        public override void Init()
        {
            _toggleButtonCharacter.InitButton(OpenCharacterPanel, false);
            _toggleButtonMap.InitButton(OpenMapPanel, true);
            _toggleButtonSettings.InitButton(OpenSettingsPanel, false);
        }

        protected override void OnOpened()
        {
        
        }

        protected override void OnClosed()
        {
        }

        private void OpenMapPanel()
        {
            PanelManager.Instance.OpenPanel<MapPanel>();
        }

        private void OpenCharacterPanel()
        {
            PanelManager.Instance.OpenPanel<CharacterPanel>();
        }

        private void OpenSettingsPanel()
        {
            PanelManager.Instance.OpenPanel<SettingsPanel>();
        }
    }
}