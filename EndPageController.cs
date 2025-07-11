using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPageController : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1f;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("start_page");
    }

    public void TryAgain()
    {
        SceneManager.LoadScene("Area 3");
    }
}
