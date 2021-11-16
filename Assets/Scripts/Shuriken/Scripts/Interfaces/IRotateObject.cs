using UnityEngine;

public interface IRotateObject
{
    public void StartRotation();

    public void StopRotation();

    public Transform GetTransform();
}