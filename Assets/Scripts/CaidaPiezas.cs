using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaPiezas : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;

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
}