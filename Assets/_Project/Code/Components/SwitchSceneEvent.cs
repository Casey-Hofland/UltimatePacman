using UnityEngine;

// A Component meant to be used by the OnEvent Component to access the SceneHandler singleton. The OnEvent Component uses UnityEvents, which can't reference Singletons (or rather, not without giving you a hard time).
public class SwitchSceneEvent : MonoBehaviour
{
    public void LoadScene(string name)
    {
        SceneHandler.Instance.LoadScene(name);
    }

    public void LoadNextScene()
    {
        SceneHandler.Instance.LoadNextScene();
    }
}
