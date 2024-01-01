using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarEscena : MonoBehaviour
{
    // Este método se llama cuando se pulsa el botón
    public void Cargar()
    {
        SceneManager.LoadScene("Arcad3-escenario redimensionado");
    }
}