using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace BurningKnight.PanelManager
{
    public abstract class PanelManagerBase<T> : MonoBehaviour where T : PanelManagerBase<T>, new()
    {
        #region Singleton

        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                    _instance = FindObjectOfType<T>();
                return _instance;
            }
        }

        #endregion

        #region Ref

        [SerializeField] private PanelManagerSettings _settings;
        [SerializeField] private Transform _screenPanelParent;
        [SerializeField] private Transform _overlayPanelParent;

        #endregion

        private List<PanelBase> _panels = new List<PanelBase>();

        public virtual void Init()
        {
            var screens = _settings.PanelPrefabs.Where(p => p.PanelType == PanelType.Screen).ToArray();
            Array.Sort(screens);
            var overlays = _settings.PanelPrefabs.Where(p => p.PanelType == PanelType.Overlay).ToArray();
            Array.Sort(overlays);

            foreach (var prefab in screens)
            {
                CreatePanel(prefab);
            }

            foreach (var prefab in overlays)
            {
                CreatePanel(prefab);
            }
        }

        public virtual TY GetPanel<TY>() where TY : PanelBase
        {
            var panel = (TY) _panels.FirstOrDefault(p => p.GetType() == typeof(TY));
            if (!panel)
            {
                Debug.LogError($"Panel <{typeof(TY)}> not found!");
            }

            return panel;
        }

        public virtual void OpenPanel<TY, TZ>(TZ arg) where TY : PanelBase, IAcceptArg<TZ>
        {
            var panel = GetPanel<TY>();

            if (!panel)
            {
                return;
            }

            panel.AcceptArg(arg);

            OpenPanel(panel);
        }

        public virtual void OpenPanel<TY>() where TY : PanelBase
        {
            var panel = GetPanel<TY>();

            if (!panel)
            {
                return;
            }

            OpenPanel(panel);
        }


        protected virtual void OpenPanel(PanelBase panel)
        {
            if (panel.IsOpen) return;
            
            if (panel.PanelType == PanelType.Overlay)
            {
                panel.Open();
                return;
            }

            foreach (var p in _panels)
            {
                if (p == panel)
                {
                    p.Open();
                }
                else if (p.IsOpen)
                {
                    p.Close();
                }
            }
        }


        protected virtual void CreatePanel(PanelBase panel)
        {
            var parent = panel.PanelType == PanelType.Screen ? _screenPanelParent : _overlayPanelParent;
            var inst = Instantiate(panel, parent);
            inst.gameObject.SetActive(true);
            inst.Init();
            inst.gameObject.SetActive(false);
            _panels.Add(inst);
        }
    }
}