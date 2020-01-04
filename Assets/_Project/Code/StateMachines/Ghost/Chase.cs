using UnityEngine;

public class Chase : GhostStateMachineBehaviour
{
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Chases the player, as simple as it gets
        Vector2 distance = player.position - transform.position;

        movement.Move(distance);
    }
}
