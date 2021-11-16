using System;
using System.Collections;
using UnityEngine;

public class ObjectRotation : MonoBehaviour, IRotateObject
{
    [Serializable]
    public struct Speed
    {
        public float X;
        public float Y;
        public float Z;
    }

    [SerializeField] private Speed speedAxis;
    
    private Coroutine _rotation;
    
    public void StartRotation()
    {
        _rotation = StartCoroutine(Rotate());
    }

    public void StopRotation()
    {
        if (_rotation != null)
        {
            StopCoroutine(_rotation);
            _rotation = null;
        }
    }

    public Transform GetTransform()
    {
        return transform;
    }

    private IEnumerator Rotate()
    {
        Vector3 buffer = transform.localEulerAngles;
        while (true)
        {
            buffer.x += speedAxis.X * Time.deltaTime;
            buffer.y += speedAxis.Y * Time.deltaTime;
            buffer.z += speedAxis.Z * Time.deltaTime;
            transform.localEulerAngles = buffer;
            yield return null;
        }
    }
}
