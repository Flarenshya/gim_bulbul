using UnityEngine;
using UnityEngine.SceneManagement;

public class Mover : MonoBehaviour
{
    public int mushroomsCollected = 0;
    public int mushroomsRequired = 7;

    // Called when a mushroom is collected
    public void CollectMushroom()
    {
        mushroomsCollected++;
        Debug.Log("Mushroom collected! Total: " + mushroomsCollected);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NextArea"))
        {
            if (mushroomsCollected >= mushroomsRequired)
            {
                int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
                int nextSceneIndex = currentSceneIndex + 1;

                if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
                {
                    SceneManager.LoadScene(nextSceneIndex);
                }
                else
                {
                    Debug.Log("No more scenes to load!");
                }
            }
            else
            {
                Debug.Log("You need to collect more mushrooms!");
            }
        }
    }
}
