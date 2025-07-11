using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Timer timerScript;

    private void Start()
    {
        if (timerScript == null)
            timerScript = FindObjectOfType<Timer>();

        if (timerScript != null)
        {
            timerScript.OnTimerEnd += ReloadCurrentScene;
            Debug.Log("Subscribed to timer event.");
        }
        else
        {
            Debug.LogWarning("Timer script not found.");
        }
    }

    private void ReloadCurrentScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("Time's up! Reloading scene index " + currentSceneIndex);
        SceneManager.LoadScene(currentSceneIndex);
    }

    private void OnDestroy()
    {
        if (timerScript != null)
        {
            timerScript.OnTimerEnd -= ReloadCurrentScene;
        }
    }
}
