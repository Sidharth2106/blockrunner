using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject pausePanel;   // Assign in Inspector
    public GameObject gameplayPanel; // (optional) gameplay UI

    // ---------------- BUTTON FUNCTIONS ----------------
    public void LoadGamePlayScene()
    {
        SceneManager.LoadScene("LevelSelectScene");
    }
    public void ShowPausePanel()
    {
        if (pausePanel != null)
            pausePanel.SetActive(true);

        if (gameplayPanel != null)
            gameplayPanel.SetActive(false);

        Time.timeScale = 0f; // Pause the game
    }

    public void HidePausePanel()
    {
        if (pausePanel != null)
            pausePanel.SetActive(false);

        if (gameplayPanel != null)
            gameplayPanel.SetActive(true);

        Time.timeScale = 1f; // Resume the game
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Settings()
    {
        Debug.Log("Settings clicked!");
    }

    public void HomeScene()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
