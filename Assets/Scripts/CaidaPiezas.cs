using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaPiezas : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnCollisionEnter(Collision collision)
    {
        // Check if the object you collided with should stop your object
        Debug.Log("Holas");
        if (collision.gameObject.CompareTag("StopTag"))
        {
            
            rb.isKinematic = true;
        }
    }
}