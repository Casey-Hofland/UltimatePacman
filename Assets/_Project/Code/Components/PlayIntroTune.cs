using System.Collections;
using UnityEngine;

// A very badly written script that plays an effect at the start. Not to be counted on for long-term.
[RequireComponent(typeof(AudioSource))]
public class PlayIntroTune : MonoBehaviour
{
    private IEnumerator Start()
    {
        Time.timeScale = 0;

        yield return new WaitForSecondsRealtime(GetComponent<AudioSource>().clip.length);
        yield return new WaitForSecondsRealtime(1);

        Time.timeScale = 1;
        SoundManager.Instance.ChasingSound();
        Destroy(gameObject);
    }
}
