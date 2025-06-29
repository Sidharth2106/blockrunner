using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    void fixedUpdate()
    {
       transform.position=player.position; 
    }
}
