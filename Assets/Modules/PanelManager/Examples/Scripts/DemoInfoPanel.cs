using System.Collections;
using System.Collections.Generic;
using BurningKnight.PanelManager;
using UnityEngine;
using UnityEngine.UI;

public class DemoInfoPanel : PanelBase, IAcceptArg<string>
{
    [SerializeField] private Button _buttonExit;
    [SerializeField] private Text _txt;
    private string _message;

    public override void Init()
    {
        _buttonExit.onClick.AddListener(Close);
    }

    protected override void OnOpened()
    {
        ShowMessage();
    }

    protected override void OnClosed()
    {
    }

    private void ShowMessage()
    {
        _txt.text = _message;
    }

    public void AcceptArg(string arg)
    {
        _message = arg;
    }
}