using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantallaCompleta : MonoBehaviour
{
    // Variable para realizar el seguimiento del estado actual de pantalla completa
    private bool pantallaCompleta = true;

    void Start()
    {
        // Inicializa la aplicación en modo de pantalla completa o ventana según sea necesario
        Screen.fullScreen = pantallaCompleta;
    }

    // Método que se llama cuando el usuario hace clic en el botón de alternar
    public void AlternarPantallaCompleta()
    {
        // Cambia el estado de pantalla completa
        pantallaCompleta = !pantallaCompleta;

        // Aplica el cambio
        Screen.fullScreen = pantallaCompleta;
    }
}
