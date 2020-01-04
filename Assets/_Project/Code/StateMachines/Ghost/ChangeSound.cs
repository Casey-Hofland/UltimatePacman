using UnityEngine;

// A StateMachineBehaviour that can change the sound that is currently playing. Not to be used long-term.
[SharedBetweenAnimators]
public class ChangeSound : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Change the playing sound from retreating to either fleeing or chasing, depending on if no more ghosts are retreating
        animator.SetBool("Retreating", false);
        if(Toolbox.Instance.TryGetValue<GameManager>(out GameManager gameManager) && 
            !gameManager.AnyRetreating)
        {
            if(animator.GetFloat("VulnerableTime") > 0 + float.Epsilon)
                SoundManager.Instance.FleeingSound();
            else
                SoundManager.Instance.ChasingSound();
        }
    }
}
