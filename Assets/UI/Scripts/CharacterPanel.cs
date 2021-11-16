using BurningKnight.PanelManager;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Scripts
{
    public class CharacterPanel : PanelBase
    {
        [SerializeField] private Button _upgradeButton;
        [SerializeField] private TMP_Text _costText;
        [SerializeField] private TMP_Text _healthText;
        [SerializeField] private TMP_Text _countShurikenText;
        [SerializeField] private TMP_Text _radiusDamageText;
        public override void Init()
        {
        }

        protected override void OnOpened()
        {
        }

        protected override void OnClosed()
        {
        }
    }
}
