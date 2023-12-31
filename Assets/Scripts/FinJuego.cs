using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinJuego : MonoBehaviour
{
    public GameObject menuGameOver;
    void OnTriggerEnter(Collider other)
    {
        menuGameOver.SetActive(true);
    }
}
