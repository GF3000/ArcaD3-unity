using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaPiezas : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;

    public LayerMask wallLayer; // Set this in the Unity editor to the layer your walls are on
    public bool isTouchingWall = false;
    public bool isTouchingFloor = false;


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
            isTouchingFloor = true;
        }
        if (collision.gameObject.CompareTag("Pared"))

        {
            isTouchingWall = true;
            // Break the game
            //Debug.Log it self name
            Debug.Log(gameObject.name + "  Tocando pared");
            //Cal Spawn function from SpawnerPiezas.cs
            Destroy(gameObject);

        }
    }

    public bool get_isTouchingWall()
    {
        return isTouchingWall;  
    }

    public bool get_isTouchingFloor()
    {
        return isTouchingFloor;
    }

    public void set_isTouchingWall(bool value)
    {
        isTouchingWall = value;
    }

    public void set_isTouchingFloor(bool value)
    {
        isTouchingFloor = value;
    }
}