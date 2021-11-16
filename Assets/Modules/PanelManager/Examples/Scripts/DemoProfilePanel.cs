using System.Collections;
using System.Collections.Generic;
using BurningKnight.PanelManager;
using BurningKnight.PanelManager.Demo;
using UnityEngine;
using UnityEngine.UI;

public class DemoProfilePanel : PanelBase, IAcceptArg<string>
{
    [SerializeField] private Text _txtUsername;
    [SerializeField] private Button _buttonLogOut;
    private string _username;
    public override void Init()
    {
        _username = string.Empty;
        _buttonLogOut.onClick.AddListener(LogOut);
    }

    protected override void OnOpened()
    {
      
    }

    protected override void OnClosed()
    {
        
    }

    public void AcceptArg(string arg)
    {
        _username = arg;
    }

    private void LogOut()
    {
        _username = string.Empty;
        DemoPanelManager.Instance.OpenPanel<DemoSignInPanel>();
    }
}
