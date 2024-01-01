using UnityEngine;

public class CerrarJuego : MonoBehaviour
{
    // Este método se llama cuando se pulsa el botón
    public void CerrarAplicacion()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}