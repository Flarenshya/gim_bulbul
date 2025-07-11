using UnityEngine;

public class Diamond : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the player has Mover script
        Mover mover = other.GetComponent<Mover>();
        if (mover != null)
        {
            mover.CollectMushroom();
        }

        // Check if the player has PlayerInventory script
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
        if (playerInventory != null)
        {
            playerInventory.DiamondCollected();
        }

        // Disable or destroy the diamond after collection
        gameObject.SetActive(false); // or Destroy(gameObject);
    }
}
