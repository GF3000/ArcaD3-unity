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
        if (FirstPersonController != null)
        {
            // Establecer la posición del objeto seguidor como la posición del objeto a seguir
            /*transform.position = FirstPersonController.position;
            transform.rotation = FirstPersonController.rotation;
            
            transform.position = new Vector3(FirstPersonController.position.x, FirstPersonController.position.y + 0.8f, FirstPersonController.position.z);
        */}
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("StopTag") || other.gameObject.CompareTag("Muerte")){
            Debug.Log("Game Over");
            Time.timeScale = 0f;
        }
    }
    
    public void Death()
    {
        Time.timeScale = 0f;
        gameOverMenu.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
