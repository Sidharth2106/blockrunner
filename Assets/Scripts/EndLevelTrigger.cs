using UnityEngine;

public class EndLevelTrigger : MonoBehaviour
{
    public LevelChanger levelChanger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))

        {
            other.gameObject.GetComponent<Collider>().enabled = false;
            levelChanger.LoadNextLevel();
        }
    }
}
