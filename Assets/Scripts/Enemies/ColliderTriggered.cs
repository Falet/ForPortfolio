using System;
using UnityEngine;

public class  ColliderTriggered : MonoBehaviour
{
    public event Action<GameObject> TriggerEnter;
    [SerializeField] private EnemyStateController enemyStateController;
    private void OnTriggerEnter(Collider other)
    {
        enemyStateController.Die();//TODO Remove and rework EnemyStateController
        TriggerEnter?.Invoke(gameObject);
    }
}
