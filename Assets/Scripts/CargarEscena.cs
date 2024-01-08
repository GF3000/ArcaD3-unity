using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarEscena : MonoBehaviour
{
    public float segundosEspera = 2f;
    public void Cargar()
    {
        StartCoroutine(Esperar(segundosEspera));
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    
    private IEnumerator Esperar(float segundos)
    {
        yield return new WaitForSeconds(segundos);
    }
}