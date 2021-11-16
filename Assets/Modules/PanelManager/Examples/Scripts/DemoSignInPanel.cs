using System.Collections;
using System.Collections.Generic;
using BurningKnight.PanelManager;
using UnityEngine;
using UnityEngine.UI;

namespace BurningKnight.PanelManager.Demo
{
    public class DemoSignInPanel : PanelBase
    {
        [SerializeField] private InputField _login;
        [SerializeField] private InputField _password;
        [SerializeField] private Button _buttonSubmit;

        public override void Init()
        {
            _buttonSubmit.onClick.AddListener(OnSubmit);
        }

        protected override void OnOpened()
        {
            _login.text = string.Empty;
            _password.text = string.Empty;
        }

        protected override void OnClosed()
        {
        }

        private void OnSubmit()
        {
            if (string.IsNullOrEmpty(_login.text))
            {
                DemoPanelManager.Instance.OpenPanel<DemoInfoPanel, string>("Login is empty!");
                return;
            }

            DemoPanelManager.Instance.OpenPanel<DemoProfilePanel, string>(_login.text);
        }
    }
}