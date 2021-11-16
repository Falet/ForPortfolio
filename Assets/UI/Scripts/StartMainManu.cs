using System;
using System.Collections;
using System.Collections.Generic;
using UI.Scripts;
using UnityEngine;

public class StartMainManu : MonoBehaviour
{
    private PanelManager _panelManager;
    private void Awake()
    {
        _panelManager = PanelManager.Instance;
        _panelManager.Init();
    }

    // Start is called before the first frame update
    void Start()
    {
        _panelManager.OpenPanel<HUDPanel>();
    }
}
