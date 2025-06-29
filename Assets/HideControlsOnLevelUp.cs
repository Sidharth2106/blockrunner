using UnityEngine;

public class HideControlsOnLevelUp : MonoBehaviour
{
    public GameObject levelCompleteCanvas;  // Drag your LevelComplete canvas here
    public GameObject leftButton;           // Drag Left Move button
    public GameObject rightButton;          // Drag Right Move button
    public GameObject topButton;            // Drag BackToLevel or Pause button

    void Update()
    {
        if (levelCompleteCanvas.activeSelf)
        {
            leftButton.SetActive(false);
            rightButton.SetActive(false);
            topButton.SetActive(false);
        }
        else
        {
            leftButton.SetActive(true);
            rightButton.SetActive(true);
            topButton.SetActive(true);
        }
    }
}
