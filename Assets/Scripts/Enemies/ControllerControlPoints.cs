using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerControlPoints : MonoBehaviour
{
    public event Action LevelIsOver;
    public event Action<Transform> ControlPointIsOver;
    
    [SerializeField] private List<AvailabilityControlPoint> controlPoints;
    [SerializeField] private float timeBetweenControlPoints;

    private int _indexCP;
    private Action _onControlPointIsOver;

    public void Init()
    {
        _onControlPointIsOver = OnControlPointIsOver;
        controlPoints[_indexCP].ControlPointIsOver += _onControlPointIsOver;
        controlPoints[_indexCP].EnableControlPoint();
        ControlPointIsOver?.Invoke(controlPoints[_indexCP].transform);
    }

    private void OnControlPointIsOver()
    {
        _indexCP++;
        if (_indexCP < controlPoints.Count)
        {
            controlPoints[_indexCP - 1].ControlPointIsOver -= _onControlPointIsOver;
            controlPoints[_indexCP].ControlPointIsOver += _onControlPointIsOver;
            ControlPointIsOver?.Invoke(controlPoints[_indexCP].transform);
            StartCoroutine(CooldownForChangeControlPoint());
        }
        else
        {
            controlPoints[_indexCP - 1].ControlPointIsOver -= _onControlPointIsOver;
            LevelIsOver?.Invoke();
        }
    }
    
    private IEnumerator CooldownForChangeControlPoint()
    {
        yield return new WaitForSeconds(timeBetweenControlPoints);
        controlPoints[_indexCP].EnableControlPoint();
    }
}