using System;
using UnityEngine;

public class DamageColliderTrigger : MonoBehaviour
{
    public event Action ColliderTriggered;

    private void OnTriggerEnter(Collider other)
    {
        var bullet = other.gameObject.GetComponent<IDamageableBullet>();
        if (bullet != null)
        {
            bullet.Caught();
            ColliderTriggered?.Invoke();
        }
    }
}