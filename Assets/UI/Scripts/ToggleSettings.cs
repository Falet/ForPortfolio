using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSettings : MonoBehaviour
{
    [SerializeField] private RectTransform _handle;
    [SerializeField] private Button _buttonToggle;
    [SerializeField] private Vector2 _endPos;
    [SerializeField] private Vector2 _startPos;
    [SerializeField] private AnimationCurve _animationCurve;
    [SerializeField] private float _animationTime;
    
    public bool isOn;
    
    private bool isForwarded;
    private bool isAnimated = false;

    private Action OnToggleClick;
    private Action OffToggleClick;
    
    private void OnEnable()
    {
        _buttonToggle.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        _buttonToggle.onClick.AddListener(OnClick);
    }

    public void Init(bool isEnable, Action onEvent, Action offEvent)
    {
        OnToggleClick = onEvent;
        OffToggleClick = offEvent;
        if (!isEnable) return;
        isOn = true;
        _handle.DOAnchorPosX(Mathf.Abs(_startPos.x), 0);
    }

    private void SelectOn()
    {
        if (isAnimated || isOn)
            return;
        OnToggleClick?.Invoke();
        isOn = true;
        isAnimated = true;
        _handle.DOAnchorPosX(Mathf.Abs(_startPos.x), _animationTime).OnComplete(delegate { isAnimated = false;});
    }
    private void SelectOff()
    {
        if (isAnimated || !isOn)
            return;
        OffToggleClick?.Invoke();
        isOn = false;
        isAnimated = true;
        _handle.DOAnchorPosX(_endPos.x, _animationTime).OnComplete(delegate { isAnimated = false;});
    }

    private Tween _tween;

    private void OnClick()
    {
        if (isAnimated) return;
        if (!isOn)
        {
            SelectOn();
        }
        else
        {
            SelectOff();
        }
    }
}
