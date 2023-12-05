using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiesScript : MonoBehaviour
{
    public Transform player;
    public FirstPersonController FirstPersonController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        //Debug.Log(other.gameObject.tag);
        if (other.gameObject.CompareTag("StopTag") || other.gameObject.CompareTag("Suelo"))
        {
            Debug.Log(other.gameObject.tag);
            FirstPersonController.isGrounded = true;
        }
    }
}