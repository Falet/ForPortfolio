using System;
using UnityEngine;

[CreateAssetMenu(fileName = "DataTrajectory", menuName = "Shuriken", order = 0)]
public class DataForShurikenTrajectory : ScriptableObject
{
    [Serializable]
    public struct RangeMultiplierSinusoid
    {
        public float min;
        public float max;
    }
    [SerializeField] private float kSizeWaveSinusoid;
    [SerializeField] private int countPoints;
    [SerializeField] private RangeMultiplierSinusoid rangeMultiplierSinusoid;
    [SerializeField] private float distance;
    
    public float KSizeWaveSinusoid => kSizeWaveSinusoid;

    public int CountPoints => countPoints;

    public RangeMultiplierSinusoid RangeMultiplier
    {
        get => rangeMultiplierSinusoid;
        set => rangeMultiplierSinusoid = value;
    }
    
    public float Distance
    {
        get => distance;
        set => distance = value;
    }
}