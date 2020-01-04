using UnityEngine;

public class Flank: GhostStateMachineBehaviour
{
    private const float distanceInFrontOfPlayer = 2f;
    private const float flankingPointMultiplier = 2f;

    private Transform flankBase;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);

        flankBase = animator.GetComponent<Ghost>().FlankBase;
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Chase the point that encloses the player within this ghost and the red ghost.
        Vector2 playerPoint = (Vector2)player.position + (Vector2)player.right * distanceInFrontOfPlayer;
        Vector2 blinkyPoint = (Vector2)flankBase.position;
        Vector2 flankingPoint = blinkyPoint + ((playerPoint - blinkyPoint) * flankingPointMultiplier);

        Vector2 distance = flankingPoint - (Vector2)transform.position;

        movement.Move(distance);
    }
}
