using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CaidaPiezas : MonoBehaviour
{
    public Rigidbody rb;

    public bool isTouchingWall = false;
    public bool isTouchingFloor = false;
    public bool godMode = false;
    

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
            gameObject.tag = "StopTag";
            AddTagRecursively(transform, "StopTag");
        }
        if (collision.gameObject.CompareTag("Pared"))

        {
            isTouchingWall = true;
            Destroy(gameObject);

        }

    }
    void AddTagRecursively(Transform trans, string tag)
    {
        trans.gameObject.tag = tag;
        if(trans.childCount > 0)
            foreach(Transform t in trans)
                AddTagRecursively(t, tag);
    }

    public bool get_isTouchingWall()
    {
        return isTouchingWall;  
    }

    public bool get_isTouchingFloor()
    {
        return isTouchingFloor;
    }

    public void setisTouchingWall(bool value)
    {
        isTouchingWall = value;
    }

    public void setisTouchingFloor(bool value)
    {
        isTouchingFloor = value;
    }

    public void setGodMode(bool value)
    {
        godMode = value;
    }
}