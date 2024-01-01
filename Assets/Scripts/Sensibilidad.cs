using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sensibilidad : MonoBehaviour
{
    public Slider sliderSensitivity;

    void Start()
    {
        // Configura el valor inicial del slider basado en la Sensibilidad actual
        sliderSensitivity.value = PlayerPrefs.GetFloat("Sensitivity", 2f);

        // Agrega un listener al evento de cambio del slider
        sliderSensitivity.onValueChanged.AddListener(CambiarSensibilidad);
    }

    void CambiarSensibilidad(float nuevaSensibilidad)
    {
        // Guarda el nuevo valor en PlayerPrefs para que persista entre sesiones
        PlayerPrefs.SetFloat("Sensitivity", nuevaSensibilidad);
        PlayerPrefs.Save();
    }
}
