using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ReinicioPuerta : MonoBehaviour
{
    public GameObject EndMenu;
    private void OnTriggerEnter(Collider other)
    {
        EndMenu.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
