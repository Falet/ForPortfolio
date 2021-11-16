using System;
using UnityEngine;

public class BehaviourStandOnLineFire : MonoBehaviour, IBehaviourStandOnLine
{
    [SerializeField] private MovementWithNavmesh movementWithNavmesh;

    private DataSinusiod _sinusiodForMove;
    
    public void Init(DataSinusiod sinusiodForMove)
    {
        _sinusiodForMove = sinusiodForMove;
    }
    
    public void StartBehaviour()
    {
        
    }

    public void StopBehaviour()
    {
        
    }

    public void OnComplete(Action callBack)
    {
        
    }
}
