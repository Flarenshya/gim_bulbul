using UnityEngine;
using UnityEngine.SceneManagement;

public class WinArea3Checker : MonoBehaviour
{
    public PlayerInventory playerInventory;
    public int requiredDiamonds = 7;

    void Update()
    {
        if (playerInventory.NumberOfDiamonds >= requiredDiamonds)
        {
            SceneLoaderData.targetScene = "Area 3";
            SceneManager.LoadScene("load_map3");
        }
    }
}
