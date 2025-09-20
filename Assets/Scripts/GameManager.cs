using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public float RestartDelay = 1f;

    [Header("UI Panels")]
    public GameObject WinPanel;   // Assign your Win Panel in inspector

    void Start()
    {
        if (WinPanel != null)
            WinPanel.SetActive(false); // keep hidden at start
    }

    public void CompleteLevel()
    {
        if (WinPanel != null)
            WinPanel.SetActive(true); // show panel when level is won
        Time.timeScale = 0f; // pause the game
    }

    public void EndGame()
    {
        Debug.Log("end game");
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", RestartDelay);
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f; // reset time before reload
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // 👉 Call this from your "Next Level" button in Win Panel
    public void NextLevel()
    {
        Time.timeScale = 1f; // resume game
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        // If there is a next scene, load it. Otherwise, restart from first.
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
            SceneManager.LoadScene(nextSceneIndex);
        else
            SceneManager.LoadScene(0); // restart from first level
    }
}
