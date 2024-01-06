using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabezaScript : MonoBehaviour
{
    public Transform FirstPersonController;
    public GameObject gameOverMenu;
<<<<<<< HEAD
=======
    public float distanciaArriba = 5f;
    public GameObject warning;
    public bool activa = false;
>>>>>>> 1ba210a319e6f6da343a24c64ead050a3abab63d

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        /*if (FirstPersonController != null)
        {
            // Establecer la posición del objeto seguidor como la posición del objeto a seguir
            transform.position = FirstPersonController.position;
            transform.rotation = FirstPersonController.rotation;
            
            transform.position = new Vector3(FirstPersonController.position.x, FirstPersonController.position.y + 0.8f, FirstPersonController.position.z);
        }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if(other.gameObject.CompareTag("Muerte"))
            Death();
    }

    public void Death()
    {
        if (PlayerPrefs.GetInt("Mode", 0) == 0)
        {
=======
        WarningCheck();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if(other.gameObject.CompareTag("Muerte"))
            Death();
    }

    public void Death()
    {
        if (PlayerPrefs.GetInt("Mode", 0) == 0)
        {
>>>>>>> 1ba210a319e6f6da343a24c64ead050a3abab63d
            Time.timeScale = 0f;
            gameOverMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    
    private void WarningCheck()
    {
        Vector3 boxSize = new Vector3(0.5f, distanciaArriba, 0.5f);
        Vector3 origin = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
        Vector3 direction = transform.TransformDirection(Vector3.up);

        RaycastHit[] hits = Physics.BoxCastAll(origin, boxSize, direction, Quaternion.identity, distanciaArriba);

        foreach (RaycastHit hit in hits)
        {
            if (hit.collider.gameObject.CompareTag("Muerte"))
            {
                Debug.DrawLine(origin, hit.point, Color.red);
                warning.SetActive(true);
                activa = true;
            }
            else
            {
                activa = false;
            }
        }
        
        if (!activa)
        {
            warning.SetActive(false);
            activa = true;
        }
    }

    private void OnDrawGizmos()
    {
        
        Vector3 boxSize = new Vector3(0.5f, distanciaArriba, 0.5f);
        Vector3 origin = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
        Vector3 direction = transform.TransformDirection(Vector3.up);

        
        //Gizmos.DrawWireCube(origin + direction * distanciaArriba * 0.5f, boxSize);
        //Debug.DrawRay(origin, direction * distanciaArriba, Color.green);
    }
}
