using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabezaScript : MonoBehaviour
{
    public Transform FirstPersonController;
    public GameObject gameOverMenu;
    public float distanciaArriba = 5f;
    public GameObject warning;
    public bool activa = false;

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Mode", 0) != 0) // Si no es modo difícil (modo facil)
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
        if (PlayerPrefs.GetInt("Mode", 0) != 2) // Si no es modo infinito (modo facil)
        {
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
