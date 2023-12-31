using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverAInicio : MonoBehaviour
{
    public float segundosEspera = 2f;
    public void Cargar()
    {
        StartCoroutine(Esperar(segundosEspera));
        SceneManager.LoadScene("Menu Principal");
    }
    
    private IEnumerator Esperar(float segundos)
    {
        yield return new WaitForSeconds(segundos);
    }
}