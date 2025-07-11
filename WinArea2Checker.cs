using UnityEngine;
using UnityEngine.SceneManagement;

public class WinArea2Checker : MonoBehaviour
{
    public PlayerInventory playerInventory;
    public int requiredDiamonds = 7;

    void Update()
    {
        if (playerInventory.NumberOfDiamonds >= requiredDiamonds)
        {
            SceneLoaderData.targetScene = "Area 2";
            SceneManager.LoadScene("load_map2");
        }
    }
}
