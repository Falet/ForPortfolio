using System;
using System.Collections.Generic;
using UnityEngine;

public class VisualizationTrajectory : MonoBehaviour
{
    public EventHandler NonAllocDelegateOnPointsOfTrajectoryUpdated { get; private set; }
    
    //TODO на объекте должен быть MeshRender
    [SerializeField] private GameObject prefabPoint;
    
    private Transform[] _arrayPoints;
    private IReadOnlyList<Vector3> _updateArrayPoints;
    private MeshRenderer[] _meshRenderers;

    private void Awake()
    {
        NonAllocDelegateOnPointsOfTrajectoryUpdated = OnPointsOfTrajectoryUpdated;
    }

    public void Init(IReadOnlyList<Vector3> updateArrayPoints)
    {
        _updateArrayPoints = updateArrayPoints;
        
        _arrayPoints = new Transform[updateArrayPoints.Count];
        _meshRenderers = new MeshRenderer[updateArrayPoints.Count];
        
        for (int i = 0; i < _arrayPoints.Length; i++)
        {
            var prefab = Instantiate(prefabPoint);
            _arrayPoints[i] = prefab.transform;
            _meshRenderers[i] = prefab.GetComponent<MeshRenderer>();
        }
        
        OnPointsOfTrajectoryUpdated();
    }

    public void OnPointsOfTrajectoryUpdated(object sender, EventArgs e)
    {
        OnPointsOfTrajectoryUpdated();
    }

    public void OnPointsOfTrajectoryUpdated()
    {
        if (!enabled || _arrayPoints == null) return;
        for (int i = 0; i < _arrayPoints.Length; i++)
        {
            _arrayPoints[i].position = _updateArrayPoints[i];
        }
    }
    
    private void OnEnable()
    {
        if (_meshRenderers != null)
        {
            for (int i = 0; i < _meshRenderers.Length; i++)
            {
                _meshRenderers[i].enabled = true;
            }
        }
    }

    private void OnDisable()
    {
        if (_meshRenderers != null)
        {
            for (int i = 0; i < _meshRenderers.Length; i++)
            {
                if (_meshRenderers[i] != null)
                {
                    _meshRenderers[i].enabled = false;
                }
            }
        }
    }
}
