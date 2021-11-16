using UnityEngine;

public static class Sinusoid
{
    public static void CalculateSinusoidalTrajectoryArray(float zPosPoint,float incrementZPos, float distance, 
        float multiplierSinusoid,ref Vector3[] pointsOfTrajectory)
    {
        for (int i = 0; i < pointsOfTrajectory.Length; i++, zPosPoint += incrementZPos)
        {
            float radian;
            if (zPosPoint == 0)
            {
                radian = 0;
            }
            else
            {
                radian = Mathf.PI * (zPosPoint / distance);
            }
            pointsOfTrajectory[i].x = multiplierSinusoid * Mathf.Sin(radian);
            pointsOfTrajectory[i].z = zPosPoint;
        }
    }
    public static void CalculateSinusoidalTrajectoryArrayWithTurnAndDisplacement(float zPosPoint,float incrementZPos, float distance, 
        float multiplierSinusoid, float rotation,ref Vector3[] pointsOfTrajectory,Vector3 displacementVector)
    {
        rotation *= Mathf.PI / 180;
        for (int i = 0; i < pointsOfTrajectory.Length; i++, zPosPoint += incrementZPos)
        {
            float radian;
            if (zPosPoint == 0)
            {
                radian = 0;
            }
            else
            {
                radian = Mathf.PI * (zPosPoint / distance);
            }
            pointsOfTrajectory[i].x = (multiplierSinusoid * Mathf.Sin(radian) + displacementVector.x) * Mathf.Cos(rotation) - 
                                      zPosPoint * Mathf.Sin(rotation);

            pointsOfTrajectory[i].z = multiplierSinusoid * Mathf.Sin(radian) * Mathf.Sin(rotation) +
                                      (zPosPoint * Mathf.Cos(rotation) + displacementVector.z);
        }
    }
}