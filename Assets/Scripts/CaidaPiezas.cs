using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaPiezas : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public LayerMask wallLayer; // Set this in the Unity editor to the layer your walls are on

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        
        // Check if the object you collided with should stop your object
        if (collision.gameObject.CompareTag("StopTag"))
        {
            //rb.velocity = new Vector3(0,0,0);
            rb.isKinematic = true;
        }
    }

    public bool isTouchingWall(Vector3 position)
    {
        // Check if the object is touching a object tagged as a "Pared"
        return Physics.CheckSphere(position, 0.1f, LayerMask.GetMask("Pared"));


        // int random = (int)Random.Range(0f, 2f);
        // return random == 1;
    }
}