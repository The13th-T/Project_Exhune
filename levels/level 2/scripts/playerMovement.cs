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
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, Vector3.down);
        RaycastHit hit;
        Debug.DrawRay(transform.position, Vector3.down * 1f, Color.red);

        if (Physics.Raycast(ray, out hit, 1f))
        {
            Debug.Log("Hit: " + hit.collider.gameObject.name);
        }
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
            if (Physics.Raycast(ray, out hit, 1f))
            {
                transform.Translate(0, 20 * Time.deltaTime, 0);
            }
        }
        
    }
    
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit: " + collision.gameObject.name);
    }
}
