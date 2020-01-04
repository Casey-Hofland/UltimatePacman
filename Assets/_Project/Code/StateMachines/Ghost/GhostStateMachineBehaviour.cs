using UnityEngine;

// This class defines basic GhostStateMachineBehaviour. Inherit a new GhostStateMachineBehaviour from this class.
[SharedBetweenAnimators]
public abstract class GhostStateMachineBehaviour: StateMachineBehaviour
{
    protected Transform transform = null;
    protected Transform player = null;
    protected Movement2D movement = null;

    public override async void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        transform = animator.transform;
        player = (await Toolbox.Instance.GetValueAsync<Player>()).transform;
        movement = animator.GetComponent<Movement2D>();
    }
}
