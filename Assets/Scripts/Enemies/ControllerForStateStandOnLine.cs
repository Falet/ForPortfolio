using System;
using System.Collections.Generic;
using UnityEngine;

public class ControllerForStateStandOnLine : MonoBehaviour
{
    [Serializable]
    private struct RangeRandom
    {
        public int max;
        public int min;
    }
    [SerializeField] private SinusoidalArray sinusoidalArray;
    [SerializeField] private int timeForCallLogic;//TODO Вынести в ScriptableObject
    [SerializeField] private RangeRandom rangeRandom;//TODO Вынести в ScriptableObject

    private Dictionary<GameObject,DataSinusiod> _positionEnemyOnLine;
    private IReadOnlyList<EnemyStateController> _enemiesAtControlPoint;
    private int _countIterationForNextLogic;
    private float _countTimeAfterLastCallLogic;
    private EnemyStateController _enemyStateController;

    public void Init(int countEnemies, IReadOnlyList<EnemyStateController> enemiesAtControlPoint)
    {
        _positionEnemyOnLine = new Dictionary<GameObject, DataSinusiod>(countEnemies); 
        _enemiesAtControlPoint = enemiesAtControlPoint;
    }

    public DataSinusiod GetPosition(GameObject key)
    {
        return _positionEnemyOnLine.TryGetValue(key, out var value) ? value : null;
    }

    private void FixedUpdate()
    {
        _countTimeAfterLastCallLogic += Time.deltaTime;
        if (_countTimeAfterLastCallLogic >= timeForCallLogic)
        {
            RandomPositionOnSinusoid();
        }
    }

    private void RandomPositionOnSinusoid()
    {
        /*for (int i = 0; i < _enemiesAtControlPoint.Count; i++)
        {
            if (_positionEnemyOnLine.TryGetValue(_enemiesAtControlPoint[i], out var value))
            {
                
            }
        }*/
    }
}