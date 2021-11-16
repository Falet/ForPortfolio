using System;
using UnityEngine;

public class ShurikenPlayer : MonoBehaviour
{
    public event EventHandler ThrowObject;
    public event EventHandler ResolveActions;
    public event EventHandler BlockActions;
    public EventHandler<Vector2> NonAllocDelegateOnOneTapedIgnoredDoubleTap { get; private set; }
    
    [SerializeField] private int startCountShuriken = 3;
    [SerializeField] private float speedMovement = 3.5f;
    [SerializeField] private MovementWithNavmesh movement;
    [SerializeField] private AnimationControllerPlayer animationControllerPlayer;
    [SerializeField] private int health;

    private Action _onCompleteMovementToPoint;
    private Transform _currentFinishTransform;
    private bool _oldOrientation;
    private int _countShuriken;

    private void Awake()
    {
        NonAllocDelegateOnOneTapedIgnoredDoubleTap = InputOnOneTapedIgnoredDoubleTap;

        _onCompleteMovementToPoint = OnCompleteMovementToPoint;
    }

    public void Init()
    {
        
    }
    
    private void InputOnOneTapedIgnoredDoubleTap(object sender, Vector2 e)
    {
        if (_countShuriken > 0)
        {
            animationControllerPlayer.Attack();
            ThrowObject?.Invoke(this,EventArgs.Empty);
            _countShuriken--;
        }
        else
        {
            Debug.Log("Shuriken is over" );
            animationControllerPlayer.Death();
            BlockActions?.Invoke(this,EventArgs.Empty);
            //Invoke gameIsEnd or REKLAMA
        }
    }
    
    private void OnCompleteMovementToPoint()
    {
        movement.transform.localRotation = _currentFinishTransform.localRotation;
        if (_oldOrientation)
        {
            animationControllerPlayer.EndMoveR();
        }
        else
        {
            animationControllerPlayer.EndMoveL();   
        }
        ResolveActions?.Invoke(this, EventArgs.Empty);
    }
    
    private void OnEnable()
    {
        movement.CompleteMovementToPoint += _onCompleteMovementToPoint;
    }

    private void OnDisable()
    {
        movement.CompleteMovementToPoint -= _onCompleteMovementToPoint;
    }

    public void MoveToControlPoint(Transform finishTransform)
    {
        _countShuriken = startCountShuriken;
        _currentFinishTransform = finishTransform;
        movement.SetDestination(_currentFinishTransform.position,speedMovement);
        animationControllerPlayer.Move();
        BlockActions?.Invoke(this,EventArgs.Empty);
    }

    public void ChangeOrientationIdle(bool isRightOrientation)
    {
        if (_oldOrientation != isRightOrientation)
        {
            if (isRightOrientation)
            {
                animationControllerPlayer.IdleR();
            }
            else
            {
                animationControllerPlayer.IdleL();
            }
        }
        _oldOrientation = isRightOrientation;
    }

    public void TakeDamage()
    {
        health -= 1;
        if (health <= 0)
        {
            Debug.Log("PlayerDead");
            animationControllerPlayer.Death();
            BlockActions?.Invoke(this,EventArgs.Empty);
            //Invoke gameIsOver
            return;
        }
        animationControllerPlayer.Damaged();
    }
}
