using System;
using UnityEngine;

namespace BurningKnight.PanelManager
{
    public abstract class PanelBase : MonoBehaviour, IComparable<PanelBase>
    {
        [SerializeField] private int _order = 0;
        public int Order => _order;

        [SerializeField] private PanelType _panelType = PanelType.Screen;
        public PanelType PanelType => _panelType;
        public abstract void Init();
        protected abstract void OnOpened();
        protected abstract void OnClosed();


        public event Action Opened;
        public event Action Closed;

        public bool IsOpen => gameObject.activeSelf;

        public void Open()
        {
            if (IsOpen) return;
            
            gameObject.SetActive(true);
            OnOpened();
            Opened?.Invoke();
        }

        public void Close()
        {
            if (IsOpen == false) return;
            gameObject.SetActive(false);
            OnClosed();
            Closed?.Invoke();
        }

        public int CompareTo(PanelBase other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return _order.CompareTo(other._order);
        }
    }
}