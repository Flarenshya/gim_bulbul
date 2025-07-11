using UnityEngine;
using UnityEngine.SceneManagement;

public class WinConditionChecker : MonoBehaviour
{
    public PlayerInventory playerInventory;
    public string winSceneName = "end_page";
    public int requiredDiamonds = 7;

    void OnEnable()
    {
        playerInventory.OnDiamondCollected.AddListener(CheckWinCondition);
    }

    void OnDisable()
    {
        playerInventory.OnDiamondCollected.RemoveListener(CheckWinCondition);
    }

    void CheckWinCondition(PlayerInventory inventory)
    {
        if (inventory.NumberOfDiamonds >= requiredDiamonds)
        {
            SceneManager.LoadScene(winSceneName);
        }
    }
}
