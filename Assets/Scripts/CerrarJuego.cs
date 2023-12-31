using UnityEngine;

public class CerrarJuego : MonoBehaviour
{
    public void CerrarAplicacion()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}