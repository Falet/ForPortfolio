using System;
using System.Collections.Generic;
using UnityEngine;

public class AvailabilityControlPoint : MonoBehaviour
{
    public event Action ControlPointIsOver;

    public IReadOnlyList<EnemyStateController> EnemiesAtControlPoint => enemiesAtControlPoint;

    [SerializeField] private List<EnemyStateController> enemiesAtControlPoint;
    [SerializeField] private DataForShurikenTrajectory.RangeMultiplierSinusoid rangeSinusoid;
    [SerializeField] private float distance;

    private DataForShurikenTrajectory _dataForShurikenTrajectory;
    
    public void Init(DataForShurikenTrajectory dataForShurikenTrajectory)
    {
        _dataForShurikenTrajectory = dataForShurikenTrajectory;
    }
    
    public void EnableControlPoint()
    {
        for (int i = 0; i < enemiesAtControlPoint.Count; i++)
        {
            enemiesAtControlPoint[i].Activate();
        }

        _dataForShurikenTrajectory.RangeMultiplier = rangeSinusoid;
        _dataForShurikenTrajectory.Distance = distance;
    }
    
    public void AddEnemyToList(EnemyStateController enemy)
    {
        enemiesAtControlPoint.Add(enemy); 
    }

    public void RemoveEnemyFromList(EnemyStateController enemy)
    {
        enemiesAtControlPoint.Remove(enemy);
        enemy.Deactivate();
        if (enemiesAtControlPoint.Count == 0)
        {
            ControlPointIsOver?.Invoke();
        }
    }
}