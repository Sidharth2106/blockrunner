using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayPanel : MonoBehaviour
{
    private PlayerControl _playerControl;
    // Start is called before the first frame update
    void Start()
    {
        _playerControl = FindObjectOfType<PlayerControl>();
    }
    
    public void MoveLeft()
    {
        _playerControl.MoveLeft();
    }

    // Called by UI button (Move Right)
    public void MoveRight()
    {
        _playerControl.MoveRight();
    }
    public void StopMoving()
    {
        _playerControl.StopMoving();
    }
}
