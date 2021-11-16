using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControllerEnemy : MonoBehaviour
{
    [SerializeField] private Animator animator;
    
    private readonly int _move = Animator.StringToHash("Move");
    private readonly int _fire = Animator.StringToHash("Fire");
    private readonly int _death = Animator.StringToHash("Death");

    public void Fire()
    {
        animator.SetTrigger(_fire);
    }
    
    public void Move(bool isMove)
    {
        animator.SetBool(_move, isMove);
    }

    public void Death()
    {
        animator.SetTrigger(_death);
    }
}
