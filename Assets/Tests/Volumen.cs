using UnityEngine;
using UnityEngine.UI;

public class Volumen : MonoBehaviour
{
    public Slider sliderVolumen;

    void Start()
    {
        // Configura el valor inicial del slider basado en el volumen actual
        sliderVolumen.value = PlayerPrefs.GetFloat("Volumen", 1.0f);

        // Agrega un listener al evento de cambio del slider
        sliderVolumen.onValueChanged.AddListener(CambiarVolumen);
    }

    public void CambiarVolumen(float nuevoVolumen)
    {
        // Ajusta el volumen global del juego
        AudioListener.volume = nuevoVolumen;

        // Guarda el nuevo valor en PlayerPrefs para que persista entre sesiones
        PlayerPrefs.SetFloat("Volumen", nuevoVolumen);
        PlayerPrefs.Save();
    }
}

