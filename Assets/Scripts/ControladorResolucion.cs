using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ControladorResolucion : MonoBehaviour
{
    public TMPro.TMP_Dropdown dropdownResolucion;

    private List<Resolution> resolucionesDisponibles;

    void Start()
    {
        resolucionesDisponibles = ObtenerResolucionesUnicas(Screen.resolutions);

        dropdownResolucion.ClearOptions();

        List<string> opciones = new List<string>();
        foreach (Resolution resolucion in resolucionesDisponibles)
        {
            string opcion = $"{resolucion.width} x {resolucion.height}";
            opciones.Add(opcion);
        }

        dropdownResolucion.AddOptions(opciones);

        dropdownResolucion.onValueChanged.AddListener(CambiarResolucion);
    }

    void CambiarResolucion(int indice)
    {
        Resolution resolucionSeleccionada = resolucionesDisponibles[indice];
        Screen.SetResolution(resolucionSeleccionada.width, resolucionSeleccionada.height, Screen.fullScreen);
    }

    List<Resolution> ObtenerResolucionesUnicas(Resolution[] resoluciones)
    {
        List<Resolution> resolucionesUnicas = new List<Resolution>();

        foreach (Resolution resolucion in resoluciones)
        {
            if (!ResolucionEstaEnLaLista(resolucion, resolucionesUnicas))
            {
                resolucionesUnicas.Add(resolucion);
            }
        }

        return resolucionesUnicas;
    }

    bool ResolucionEstaEnLaLista(Resolution resolucion, List<Resolution> lista)
    {
        foreach (Resolution res in lista)
        {
            if (res.width == resolucion.width && res.height == resolucion.height)
            {
                return true;
            }
        }
        return false;
    }
}