using BurningKnight.PanelManager;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Scripts
{
    public class EndGamePanel : PanelBase
    {
        [SerializeField] private Button _getDoubleRewardButton;
        [SerializeField] private Button _continueButton;
        [SerializeField] private Button _exitButton;
        [SerializeField] private TMP_Text _countMoney;
        [SerializeField] private TMP_Text _countDoubleMoney;
        [SerializeField] private GameObject _completeContent;
        [SerializeField] private GameObject _failedContent;

        public override void Init()
        {
        }

        protected override void OnOpened()
        {
            _getDoubleRewardButton.onClick.AddListener(OnGetDoubleReward);
            _continueButton.onClick.AddListener(OnContinueStage);
            _exitButton.onClick.AddListener(OnExit);
        }

        protected override void OnClosed()
        {
            _getDoubleRewardButton.onClick.AddListener(OnGetDoubleReward);
            _continueButton.onClick.AddListener(OnContinueStage);
            _exitButton.onClick.AddListener(OnExit);
        }

        public void ShowCompleteContent()
        {
            _completeContent.SetActive(true);
            _failedContent.SetActive(false);
        }
        
        public void ShowFailedContent()
        {
            _failedContent.SetActive(true);
            _completeContent.SetActive(false);
        }

        private void OnGetDoubleReward() { }
        private void OnContinueStage() { }
        private void OnExit() { }
        
    }
}