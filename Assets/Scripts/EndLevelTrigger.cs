using UnityEngine;

public class EndLevelTrigger : MonoBehaviour
{
    public GameObject winPanel; // Assign your Win Panel in Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Disable player collider so it doesn’t trigger twice
            other.gameObject.GetComponent<Collider>().enabled = false;

            // Show Win Panel
            if (winPanel != null)
                winPanel.SetActive(true);

            // Optional: pause the game
            Time.timeScale = 0f;
        }
    }
}
