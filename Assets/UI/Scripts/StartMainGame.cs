using UnityEngine;

namespace UI.Scripts
{
    public class StartMainGame : MonoBehaviour
    {
        private PanelManager _panelManager;
        private MainGamePanel _mainGamePanel;
        private void Awake()
        {
            _panelManager = PanelManager.Instance;
            _panelManager.Init();
            _mainGamePanel = _panelManager.GetPanel<MainGamePanel>();
            _mainGamePanel.Init("Region 1", 4, 3, 4);
        }

        // Start is called before the first frame update
        void Start()
        {
            _panelManager.OpenPanel<MainGamePanel>();
        }
    }
}