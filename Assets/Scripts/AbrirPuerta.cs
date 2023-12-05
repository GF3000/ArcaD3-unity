using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuerta : MonoBehaviour
{
    public Animator laPuerta;

    void OnTriggerEnter(Collider other)
    {
        laPuerta.Play("abrir");
    }

    void OnTriggerExit(Collider other)
    {
        laPuerta.Play("cerrar");
    }
}
