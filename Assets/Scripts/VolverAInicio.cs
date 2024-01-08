using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverAInicio : MonoBehaviour
{
    public float segundosEspera = 2f;
    public void Cargar()
    {
        StartCoroutine(Esperar(segundosEspera));
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    
    private IEnumerator Esperar(float segundos)
    {
        yield return new WaitForSeconds(segundos);
    }
}