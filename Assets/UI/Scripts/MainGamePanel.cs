using BurningKnight.PanelManager;
using JetBrains.Annotations;
using TMPro;
using UI.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class MainGamePanel : PanelBase
{
    [SerializeField] private Image _iconShuriken;
    [SerializeField] private TMP_Text _headerText;
    [SerializeField] private TMP_Text _counterMoney;
    [SerializeField] private TMP_Text _counterTargets;
    [SerializeField] private Button _pauseButton;
    [SerializeField] private IndicatorShuriken _prefabIndicatorShuriken;
    [SerializeField] private StagePanel _prefabStagePanel;
    [SerializeField] private Transform _containerCountShuriken;
    [SerializeField] private Transform _containerCountStage;
    
    public override void Init()
    {
       
    }
    
    public void Init(string nameLevel, int countStages, int countShuriken, int countTargets)
    {
        _headerText.text = nameLevel;
        _counterMoney.text = "0";
        _counterTargets.text = $"{countTargets}";
        InitStages(countStages);
        InitShurikenContent(countShuriken);
    }
    
    protected override void OnOpened()
    {
        _pauseButton.onClick.AddListener(OnPause);
    }

    protected override void OnClosed()
    {
        _pauseButton.onClick.RemoveListener(OnPause);
    }
    
    private void InitStages(int countStages)
    {
        for (var i = 0; i < countStages; i++)
        {
            var stagePanel = Instantiate(_prefabStagePanel, _containerCountStage);
            stagePanel.InitWithoutText(stagePanel.CurrentStageColor); 
        }
    }
    
    private void InitShurikenContent(int countShuriken)
    {
        for (var i = 0; i < countShuriken; i++)
        {
            var indicatorShuriken = Instantiate(_prefabIndicatorShuriken, _containerCountShuriken);
            indicatorShuriken.SetColor(false);
        }
    }

    private void OnPause()
    {
        PanelManager.Instance.OpenPanel<PausePanel>();
    }
}
