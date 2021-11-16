using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    public event Action CompletedThrow;
    public EventHandler NonAllocDelegateThrow { get; private set; }
    
    [SerializeField] private float duration = 1f;
    [SerializeField] private float offsetY;
    
    private IRotateObject _rotationObject;
    private IReadOnlyList<Vector3> _arrayPointsOfTrajectory;
    private Tween _tween;
    private TweenCallback _tweenCallback;
    private Transform transformRotation;
    private Vector3[] _arrayWithDisplacement;

    private void Awake()
    {
        NonAllocDelegateThrow = Throw;
        
        _tweenCallback = OnCompletedPath;
    }

    //TODO Заменить IRotateObject на стратегию, если нужно разное поведение
    public void Init(IReadOnlyList<Vector3> arrayPointsOfTrajectory, IRotateObject rotation)
    {
        _rotationObject = rotation;
        
        _arrayPointsOfTrajectory = arrayPointsOfTrajectory;

        _arrayWithDisplacement = new Vector3[_arrayPointsOfTrajectory.Count];
    }

    public void Throw(object sender, EventArgs e)
    {
        Throw();
    }
    
    public void Throw()
    {
        if (!enabled) return;
        
        if (_tween == null)
        {
            for (int i = 0; i < _arrayPointsOfTrajectory.Count; i++)
            {
                _arrayWithDisplacement[i] = _arrayPointsOfTrajectory[i];
                _arrayWithDisplacement[i].y = offsetY;
            }
            transformRotation = _rotationObject.GetTransform();
            transformRotation.gameObject.SetActive(true);
            _rotationObject.StartRotation();
            transformRotation.position = _arrayPointsOfTrajectory[0];
            _tween = transformRotation.DOPath(_arrayWithDisplacement,duration,
                PathType.CatmullRom, PathMode.Ignore);
            _tween.OnComplete(_tweenCallback);
        }
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }

    private void OnCompletedPath()
    {
        CompletedThrow?.Invoke();
        _rotationObject.StopRotation();
        transformRotation.gameObject.SetActive(false);
        _tween?.Kill();
        _tween = null;
    }
}
