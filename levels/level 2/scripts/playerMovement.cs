using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerMovement : MonoBehaviour
{
    private float playerSpeed;
    private float playerGravity;
    private float playerJumpForce;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            transform.Translate(-20 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(20 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("up"))
        {
            transform.Translate(0, 20 * Time.deltaTime, 0);
        }
        transform.Translate(0, -20 * Time.deltaTime, 0);
    }
}
