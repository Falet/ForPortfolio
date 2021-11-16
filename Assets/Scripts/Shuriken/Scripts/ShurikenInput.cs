using System;
using UnityEngine;

public class ShurikenInput : MonoBehaviour
{
    public event EventHandler<Vector2> DragChanged;
    public event EventHandler<Vector2> OneTapedIgnoredDoubleTap;
    
    [SerializeField] private InputManager inputManager;

    private EventHandler<Vector2> _onDragChanged;
    private EventHandler<Vector2> _oneTapedIgnoredDoubleTap;
    private Vector2 _currentDragChange;

    private void Awake()
    {
        _onDragChanged = OnDragChanged;
        _oneTapedIgnoredDoubleTap = OnOneTapedIgnoredDoubleTap;
    }

    private void OnEnable()
    {
        inputManager.DragChanged += _onDragChanged;
        inputManager.OneTapedIgnoredDoubleTap += _oneTapedIgnoredDoubleTap;
    }

    private void OnDisable()
    {
        inputManager.DragChanged -= _onDragChanged;
        inputManager.OneTapedIgnoredDoubleTap -= _oneTapedIgnoredDoubleTap;
    }

    //TODO Если очередность вызова OnDragChanged и OnOneTapedIgnoredDoubleTap изменится, то OnOneTapedIgnoredDoubleTap не будет работать
    private void OnDragChanged(object sender, Vector2 e)
    {
        _currentDragChange = e;
        DragChanged?.Invoke(this,e);
    }
    
    private void OnOneTapedIgnoredDoubleTap(object sender, Vector2 e)
    {
        if (_currentDragChange == Vector2.zero)
        {
            OneTapedIgnoredDoubleTap?.Invoke(this,e);
        }
    }
}
