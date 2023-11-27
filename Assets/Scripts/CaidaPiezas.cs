using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CaidaPiezas : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;

    public bool isTouchingWall = false;
    public bool isTouchingFloor = false;
    public bool godMode = true;



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
        }
        if (collision.gameObject.CompareTag("Pared"))

        {
            isTouchingWall = true;
            Destroy(gameObject);

        }

        if (collision.gameObject.CompareTag("Player") && !gameObject.CompareTag("StopTag") && !godMode){
            Debug.Log("Game Over");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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