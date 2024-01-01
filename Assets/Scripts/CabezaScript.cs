using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabezaScript : MonoBehaviour
{
    public Transform FirstPersonController;
    public GameObject gameOverMenu;

    // Update is called once per frame
    void Update()
    {
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
            Time.timeScale = 0f;
            gameOverMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
