using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // This method will be called when a button is clicked
    public void LoadLevel(int levelIndex)
    {
        Debug.Log("Button clicked! Trying to load level index: " + levelIndex);
        SceneManager.LoadScene(levelIndex);
    }
}
