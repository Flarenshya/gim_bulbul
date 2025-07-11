using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class FakeTimedLoading : MonoBehaviour
{
    public Image progressBarFill;
    public string nextSceneName = "Next Scene"; 
    public float loadingDuration = 5f;
    void Start()
    {
        StartCoroutine(FakeLoadingRoutine());
    }

    IEnumerator FakeLoadingRoutine()
    {
        float elapsed = 0f;

        while (elapsed < loadingDuration)
        {
            elapsed += Time.deltaTime;
            float progress = Mathf.Clamp01(elapsed / loadingDuration);
            progressBarFill.fillAmount = progress;
            yield return null;
        }

        // Setelah 5 detik selesai, load scene
        SceneManager.LoadScene(nextSceneName);
    }
}
