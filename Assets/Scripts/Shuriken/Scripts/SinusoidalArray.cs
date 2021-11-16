using System;
using System.Collections.Generic;
using UnityEngine;

public class SinusoidalArray : MonoBehaviour
{
    public event EventHandler PointsOfTrajectoryUpdated;
    public event Action<bool> ChangedOrientation;
    public EventHandler<Vector2> NonAllocDelegateOnDragChanged { get; private set; }

    [SerializeField] private Transform startPoint;
    [SerializeField] private Transform endPoint;
    [SerializeField] private Transform parentForPointsSinusoid;
    [SerializeField] private Transform targetTransformForParent;
    [SerializeField] private float offsetY;
    
    private Vector3[] _pointsOfTrajectory;
    private Vector3[] _pointsOfTrajectoryTest;
    private float _zPosPoint;
    private float _incrementZPos;
    private float _multiplierSinusoid;
    private DataForShurikenTrajectory _dataForTrajectory;
    private IReadOnlyList<Vector3> _pointsOfTrajectoryReadOnly;
    
    public void Init(DataForShurikenTrajectory dataForTrajectory)
    {
        _dataForTrajectory = dataForTrajectory;

        _pointsOfTrajectoryTest = new Vector3[_dataForTrajectory.CountPoints];
        _pointsOfTrajectory = new Vector3[_dataForTrajectory.CountPoints];
        for (int i = 0; i < _pointsOfTrajectoryTest.Length; i++)
        {
            _pointsOfTrajectoryTest[i] = startPoint.position;
        }
        _pointsOfTrajectoryReadOnly = Array.AsReadOnly(_pointsOfTrajectory);

        OnEnable();

        InitSinusoid(Vector2.zero);
    }
    
    public IReadOnlyList<Vector3> GetPointsOfTrajectory()
    {
        return _pointsOfTrajectoryReadOnly;
    }
    
    public Transform GetParentTransform()
    {
        return parentForPointsSinusoid;
    }

    public void OnDragChanged(object sender, Vector2 e)
    {
        OnDragChanged(e);
    }
    
    public void OnDragChanged(Vector2 e)
    {
        if (!enabled) return;
        InitSinusoid(e);
        PointsOfTrajectoryUpdated?.Invoke(this,EventArgs.Empty);
    }
    
    private void Awake()
    {
        NonAllocDelegateOnDragChanged = OnDragChanged;
        Vector3 startPosition = targetTransformForParent.position;
        startPosition.y -= offsetY;
        parentForPointsSinusoid.position = startPosition;
    }
    
    private void OnEnable()
    {
        if (_dataForTrajectory != null)
        {
            _incrementZPos = _dataForTrajectory.Distance / _dataForTrajectory.CountPoints;

            _multiplierSinusoid = _dataForTrajectory.RangeMultiplier.max;
            
            OnDragChanged(Vector2.zero);
        }
    }

    private void InitSinusoid(Vector2 e)
    {
        var bufferMultiplierSinusoid = _multiplierSinusoid + e.x * _dataForTrajectory.KSizeWaveSinusoid;
        if (bufferMultiplierSinusoid <= _dataForTrajectory.RangeMultiplier.max && 
            bufferMultiplierSinusoid >= _dataForTrajectory.RangeMultiplier.min)
        {
            _multiplierSinusoid = bufferMultiplierSinusoid;
            if (_multiplierSinusoid < 0)
            {
                ChangedOrientation?.Invoke(false);
            }
            else if(_multiplierSinusoid > 0)
            {
                ChangedOrientation?.Invoke(true);
            }
        }
        else
        {
            return;
        }
        Sinusoid.CalculateSinusoidalTrajectoryArray(_zPosPoint,_incrementZPos,_dataForTrajectory.Distance,_multiplierSinusoid,
            ref _pointsOfTrajectoryTest);
        
        for (int i = 0; i < _pointsOfTrajectoryTest.Length; i++)
        {
            _pointsOfTrajectory[i] = parentForPointsSinusoid.localToWorldMatrix.MultiplyPoint(_pointsOfTrajectoryTest[i]);
        }
    }
}
