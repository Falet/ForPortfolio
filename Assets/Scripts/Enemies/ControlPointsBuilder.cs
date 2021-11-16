using System;
using System.Collections.Generic;
using UnityEngine;

public class ControlPointsBuilder : MonoBehaviour
{
    [SerializeField] private List<EnemiesBuilder> enemiesBuilder;
    [SerializeField] private ControllerControlPoints controllerControlPoints;

    public void Init(DataForShurikenTrajectory dataForShurikenTrajectory)
    {
        for (int i = 0; i < enemiesBuilder.Count; i++)
        {
            enemiesBuilder[i].Init(dataForShurikenTrajectory);
        }
        controllerControlPoints.Init();
    }
}