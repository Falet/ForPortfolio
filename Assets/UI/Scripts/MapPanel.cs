using System;
using BurningKnight.PanelManager;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Scripts
{
    public class MapPanel : PanelBase
    {
        [SerializeField] private Button _playGameButton;
        [SerializeField] private StagePanel _stagePanelPrefab;
        [SerializeField] private Transform _containerForButtonStage;
        public int CountStage;
        
        public override void Init()
        {
            CreateStagesButton();
        }
    
        protected override void OnOpened()
        {
            _playGameButton.onClick.AddListener(StartGame);
        }

        protected override void OnClosed()
        {
            _playGameButton.onClick.RemoveListener(StartGame);
        }
    
        private void CreateStagesButton()
        {
            for (var i = 1; i <= 5; i++)
            {
                var stageButton = Instantiate(_stagePanelPrefab, _containerForButtonStage);
                stageButton.InitWithText(i, stageButton.LockedStageColor); 
            }
        }

        private void StartGame()
        {
        
        }
    }
}
