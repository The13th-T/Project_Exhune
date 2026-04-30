using UnityEngine;

public class RayCast : MonoBehaviour
{
    private Ray ray;
    private RaycastHit[] hits;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ray = new Ray(transform.position, transform.right);
        //CheckForColliders();
    }

    // Update is called once per frame
    void Update()
    {

        //if (Physics.Raycast())
       //{
            //Debug.("Something Was Hit");
        //}
        
    }
}
