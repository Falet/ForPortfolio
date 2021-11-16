using System;
using BurningKnight.PanelManager.Demo;
using UnityEngine;

namespace BurningKnight.PanelManager
{
    public class TestManager : MonoBehaviour
    {
        private DemoPanelManager pm;

        private void Awake()
        {
            pm = DemoPanelManager.Instance;
            pm.Init();
        }

        private void Start()
        {
            pm.OpenPanel<DemoSignInPanel>();
        }
    }
}