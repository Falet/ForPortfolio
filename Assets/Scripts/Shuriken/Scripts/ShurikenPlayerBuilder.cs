using System;
using UnityEngine;

//Нужно создавать компоненты, а не иметь ссылку на существующие, ибо существующие без билдкласса никогда не могут быть валидны
public class ShurikenPlayerBuilder : MonoBehaviour
{
    [SerializeField] private ShurikenInput input;
    [SerializeField] private SinusoidalArray sinusoidalArray;
    [SerializeField] private ThrowObject throwObject;
    [SerializeField] private ObjectRotation objectRotation;
    [SerializeField] private DataForShurikenTrajectory dataForTrajectory;
    [SerializeField] private VisualizationTrajectory visualizationTrajectory;
    [SerializeField] private ShurikenPlayer shurikenPlayer;
    [SerializeField] private ControllerControlPoints controllerControlPoints;
    [SerializeField] private ControlPointsBuilder controlPointsBuilder;
    [SerializeField] private DamageColliderTrigger damageColliderTrigger;
    
    private void Start()
    {
        input.OneTapedIgnoredDoubleTap += shurikenPlayer.NonAllocDelegateOnOneTapedIgnoredDoubleTap;
        input.DragChanged += sinusoidalArray.NonAllocDelegateOnDragChanged;
        sinusoidalArray.PointsOfTrajectoryUpdated += visualizationTrajectory.NonAllocDelegateOnPointsOfTrajectoryUpdated;
        shurikenPlayer.ThrowObject += throwObject.NonAllocDelegateThrow;
        controllerControlPoints.ControlPointIsOver += shurikenPlayer.MoveToControlPoint;
        shurikenPlayer.ResolveActions += OnEnabledObject;
        shurikenPlayer.BlockActions += OnDisabledObject;
        sinusoidalArray.ChangedOrientation += shurikenPlayer.ChangeOrientationIdle;
        damageColliderTrigger.ColliderTriggered += shurikenPlayer.TakeDamage;
        
        sinusoidalArray.Init(dataForTrajectory);
        visualizationTrajectory.Init(sinusoidalArray.GetPointsOfTrajectory());
        shurikenPlayer.Init();
        throwObject.Init(sinusoidalArray.GetPointsOfTrajectory(),objectRotation);
        controlPointsBuilder.Init(dataForTrajectory);
    }

    private void OnEnabledObject(object sender, EventArgs e)
    {
        input.DragChanged += sinusoidalArray.NonAllocDelegateOnDragChanged;
        sinusoidalArray.PointsOfTrajectoryUpdated += visualizationTrajectory.NonAllocDelegateOnPointsOfTrajectoryUpdated;
        shurikenPlayer.ThrowObject += throwObject.NonAllocDelegateThrow;
        
        visualizationTrajectory.enabled = true;
        sinusoidalArray.enabled = true;
        throwObject.enabled = true;
    }
    
    private void OnDisabledObject(object sender, EventArgs e)
    {
        input.DragChanged -= sinusoidalArray.NonAllocDelegateOnDragChanged;
        sinusoidalArray.PointsOfTrajectoryUpdated -= visualizationTrajectory.NonAllocDelegateOnPointsOfTrajectoryUpdated;
        shurikenPlayer.ThrowObject -= throwObject.NonAllocDelegateThrow;
        sinusoidalArray.enabled = false;
        visualizationTrajectory.enabled = false;
        throwObject.enabled = false;
    }

    private void OnDestroy()
    {
        input.OneTapedIgnoredDoubleTap -= shurikenPlayer.NonAllocDelegateOnOneTapedIgnoredDoubleTap;
        shurikenPlayer.ResolveActions -= OnEnabledObject;
        shurikenPlayer.BlockActions -= OnDisabledObject;
        controllerControlPoints.ControlPointIsOver -= shurikenPlayer.MoveToControlPoint;
        sinusoidalArray.ChangedOrientation -= shurikenPlayer.ChangeOrientationIdle;
        damageColliderTrigger.ColliderTriggered -= shurikenPlayer.TakeDamage;
        
        OnDisabledObject(this, EventArgs.Empty);
    }
}
