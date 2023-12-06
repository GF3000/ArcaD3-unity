using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinJuego : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        
        //restart the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
