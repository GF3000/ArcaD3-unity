using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fov : MonoBehaviour
{
    public Slider sliderFov;

    void Start()
    {
        // Configura el valor inicial del slider basado en el fov actual
        sliderFov.value = PlayerPrefs.GetFloat("Fov", 60f);

        // Agrega un listener al evento de cambio del slider
        sliderFov.onValueChanged.AddListener(CambiarFov);
    }

    void CambiarFov(float nuevoFov)
    {
        // Guarda el nuevo valor en PlayerPrefs para que persista entre sesiones
        PlayerPrefs.SetFloat("Fov", nuevoFov);
        PlayerPrefs.Save();
    }
}
