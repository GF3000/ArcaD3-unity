using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarEscena : MonoBehaviour
{
    public float segundosEspera = 2f;
    public void Cargar()
    {
        StartCoroutine(Esperar(segundosEspera));
        SceneManager.LoadScene("Arcad3-escenario redimensionado");
    }
    
    private IEnumerator Esperar(float segundos)
    {
        yield return new WaitForSeconds(segundos);
    }
}