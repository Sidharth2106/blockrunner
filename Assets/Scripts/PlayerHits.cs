using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHits : MonoBehaviour
{
    public PlayerControl movement;

    [System.Obsolete]
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log(collisionInfo.collider.gameObject);
            // Trigger vibration
            Handheld.Vibrate();

            // Disable movement
            movement.enabled = false;

            // End the game
            FindObjectOfType<GameManager>().EndGame();
        }
    } 
}
