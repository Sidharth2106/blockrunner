using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody rb;
    public float FowardForce = 200f;
    public float SidewaysForce = 300f;

    private float direction = 0f; // 0 = idle, -1 = left, 1 = right

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 200, 500);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, FowardForce * Time.deltaTime);

        // Keyboard input
        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Button input (touch)
        if (direction != 0)
        {
            rb.AddForce(direction * SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }

    // Called by UI button (Move Left)
    public void MoveLeft()
    {
        direction = -1f;
    }

    // Called by UI button (Move Right)
    public void MoveRight()
    {
        direction = 1f;
    }

    // Called by UI button (on release)
    public void StopMoving()
    {
        direction = 0f;
    }
}
