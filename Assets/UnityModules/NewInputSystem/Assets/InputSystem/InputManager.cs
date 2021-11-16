using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class InputManager : MonoBehaviour
{
    public event EventHandler<float> ZoomChanged;
    public event EventHandler<Vector2> DoubleTaped;
    public event EventHandler<Vector2> OneTaped;
    public event EventHandler<Vector2> OneTapedIgnoredDoubleTap;
    public event EventHandler<Vector2> DragChanged;
    
    [SerializeField]private float speedZoom = 0.4f;
    
    private TouchInput _touchInput;
    private bool _buttonHoldZoom = true;
    private bool _buttonDrag = true;
    private Coroutine _coroutine;
    private float _newDistance;
    private float _lastDistance;
    private bool _isZooming = true;
    private Coroutine _coroutineDrag;
    
    private void Awake()
    {
        _touchInput = new TouchInput();
        _touchInput.Touch.OneTapIgnoredDoubleTap.performed += OneTap;
        _touchInput.Touch.DragTouch.performed += Drag;
        _touchInput.Touch.DragTouch.canceled += _ => _buttonDrag = false;
        _touchInput.Touch.DoubleTap.performed += DoubleTap;
        _touchInput.Touch.SecondaryTouchContact.started += _ => ZoomStart();
        _touchInput.Touch.SecondaryTouchContact.canceled += _ => ZoomEnd();
        _touchInput.Touch.MiddleClick.performed += _ => WheelZoom();
        _touchInput.Touch.ZoomUpButton.performed += ZoomUp;
        _touchInput.Touch.ZoomDownButton.performed += ZoomDown;
        _touchInput.Touch.ZoomUpButton.canceled += _ => _buttonHoldZoom = false;
        _touchInput.Touch.ZoomDownButton.canceled += _ => _buttonHoldZoom = false;
    }

    private void OnEnable()
    {
        _touchInput.Enable();
    }

    private void OnDisable()
    {
        _touchInput.Disable();
    }

    private void ZoomUp(InputAction.CallbackContext obj)
    {
        if (obj.interaction is HoldInteraction)
        {
            _buttonHoldZoom = true;
            StartCoroutine(ZoomWithHoldButton(true));
        }
        else
        {
            ZoomChanged?.Invoke(this, speedZoom);
        }
    }
    private void ZoomDown(InputAction.CallbackContext obj)
    {
        if (obj.interaction is HoldInteraction)
        {
            _buttonHoldZoom = true;
            StartCoroutine(ZoomWithHoldButton(false));
        }
        else
        {
            ZoomChanged?.Invoke(this, -speedZoom);
        }
    }

    private IEnumerator ZoomWithHoldButton(bool IsZoomUp)
    {
        while (_buttonHoldZoom)
        {
            if (IsZoomUp)
            {
                ZoomChanged?.Invoke(this, speedZoom);
            }
            else
            {
                ZoomChanged?.Invoke(this, -speedZoom);
            }
            yield return null;
        }
    }
    
    private void WheelZoom()
    {
        if (_coroutine == null)
        {
            _coroutine = StartCoroutine(ZoomWheelDetection());
        }
        else
        {
            StopCoroutine(_coroutine);
            _coroutine = null;
        }
    }

    private IEnumerator ZoomWheelDetection()
    {
        while (true)
        {
            if(_touchInput.Touch.WheelZoom.ReadValue<Vector2>().y != 0)
                ZoomChanged?.Invoke(this, _touchInput.Touch.WheelZoom.ReadValue<Vector2>().y * speedZoom);
            yield return null;
        }
    }
    
    private void ZoomStart()
    {
        _lastDistance = 0;
        _isZooming = false;
        _coroutine = StartCoroutine(ZoomDetection());
    }
    private void ZoomEnd()
    {
        _isZooming = true;
        StopCoroutine(_coroutine);
    }
    
    private IEnumerator ZoomDetection()
    {
        while (true)
        {
            _newDistance = Vector2.Distance(_touchInput.Touch.PrimaryTouchPosition.ReadValue<Vector2>(),
                _touchInput.Touch.SecondaryTouchPosition.ReadValue<Vector2>());
            
            if (Math.Abs(_lastDistance - _newDistance) * 0.05f > 0.1f && _lastDistance != 0)
            {
                ZoomChanged?.Invoke(this, (_newDistance - _lastDistance)  * 0.05f * speedZoom);
            }
            _lastDistance = _newDistance;
            yield return null;
        }
    }
    
    private void DoubleTap(InputAction.CallbackContext obj)
    {
        if (obj.interaction is TapInteraction)
        {
            //Debug.Log("OneTap");
            OneTaped?.Invoke(this,_touchInput.Touch.PrimaryTouchPosition.ReadValue<Vector2>());
        }
        else
        {
            //Debug.Log("DoubleTap");
            DoubleTaped?.Invoke(this, _touchInput.Touch.PrimaryTouchPosition.ReadValue<Vector2>());
        }
    }

    private void OneTap(InputAction.CallbackContext obj)
    {
        //Debug.Log("OneTapIgnoringDoubleTap");
        OneTapedIgnoredDoubleTap?.Invoke(this,_touchInput.Touch.PrimaryTouchPosition.ReadValue<Vector2>());
    }

    
    private void Drag(InputAction.CallbackContext obj)
    {
        //Debug.Log("Drag");
        if (_coroutineDrag == null)
        {
            _buttonDrag = true;
            _coroutineDrag = StartCoroutine(DragDetection());
        }
    }

    private Vector2 _lastValuePosTouch;
    private IEnumerator DragDetection()
    {
        while (_buttonDrag && _isZooming)
        {
            var positionMouse = _touchInput.Touch.PrimaryTouchPosition.ReadValue<Vector2>();
            var distance = new Vector2(positionMouse.x - _lastValuePosTouch.x, positionMouse.y - _lastValuePosTouch.y);
            if (_lastValuePosTouch != Vector2.zero)
            {
                if (distance != Vector2.zero)
                {
                    DragChanged?.Invoke(this, distance);
                }
            }
            else
            {
                DragChanged?.Invoke(this, Vector2.zero);
            }
            _lastValuePosTouch = positionMouse;
            yield return null;
        }
        _lastValuePosTouch = Vector2.zero;
        _coroutineDrag = null;
    }
}
