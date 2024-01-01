using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoSlider : MonoBehaviour
{
    public enum Configuracion { Volumen, Fov, Sensibilidad };

    public Configuracion configuracionSeleccionada;
    public Slider slider;
    public TMPro.TMP_Text textoValorSlider;

    void Update()
    {
        switch (configuracionSeleccionada)
        {
            case Configuracion.Volumen:
                textoValorSlider.text = Math.Round(slider.value, 2) * 100 + " %";
                break;
            case Configuracion.Fov:
                textoValorSlider.text = slider.value.ToString("F0");
                break;
            case Configuracion.Sensibilidad:
                textoValorSlider.text = slider.value.ToString("F2");
                break;
        }
    }
}
