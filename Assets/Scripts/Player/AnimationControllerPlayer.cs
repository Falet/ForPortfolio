using UnityEngine;

public class AnimationControllerPlayer : MonoBehaviour
{
    [SerializeField] private Animator animator;
    
    private readonly int _move = Animator.StringToHash("Move");
    private readonly int _endMoveL = Animator.StringToHash("EndMove_L");
    private readonly int _endMoveR = Animator.StringToHash("EndMove_R");
    private readonly int _attack = Animator.StringToHash("Attack");
    private readonly int _damaged = Animator.StringToHash("Damaged");
    private readonly int _idleL = Animator.StringToHash("Idle_L");
    private readonly int _idleR = Animator.StringToHash("Idle_R");
    private readonly int _death = Animator.StringToHash("Death");

    public void Move()
    {
        animator.SetTrigger(_move);
    }

    public void Death()
    {
        animator.SetTrigger(_death);
    }

    public void EndMoveL()
    {
        animator.SetTrigger(_endMoveL);
    }
    
    public void EndMoveR()
    {
        animator.SetTrigger(_endMoveR);
    }
    
    public void Attack()
    {
        animator.SetTrigger(_attack);
    }
    
    public void Damaged()
    {
        animator.SetTrigger(_damaged);
    }
    
    public void IdleL()
    {
        animator.SetTrigger(_idleL);
    }
    
    public void IdleR()
    {
        animator.SetTrigger(_idleR);
    }
}