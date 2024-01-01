using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Resolucion : MonoBehaviour
{
    public TMP_Dropdown resolutionDropdown;
    public Toggle fullScreenToggle;

    void Start()
    {
        PopulateResolutionsDropdown();
    }

    void PopulateResolutionsDropdown()
    {
        resolutionDropdown.ClearOptions();

        Resolution[] resolutions = Screen.resolutions;
        List<string> resolutionOptions = new List<string>();

        // Diccionario para evitar resoluciones duplicadas con diferente tasa de refresco
        Dictionary<string, Resolution> uniqueResolutions = new Dictionary<string, Resolution>();

        // Agregar resoluciones únicas al diccionario
        foreach (Resolution resolution in resolutions)
        {
            string key = $"{resolution.width} x {resolution.height}";

            if (!uniqueResolutions.ContainsKey(key))
            {
                uniqueResolutions.Add(key, resolution);
            }
        }

        // Agregar las resoluciones únicas al menú desplegable
        foreach (var entry in uniqueResolutions)
        {
            resolutionOptions.Add($"{entry.Value.width} x {entry.Value.height}");
        }

        resolutionDropdown.AddOptions(resolutionOptions);

        // Establecer la opción predeterminada como la resolución nativa
        int nativeResolutionIndex = resolutionOptions.IndexOf($"{Screen.currentResolution.width} x {Screen.currentResolution.height}");
        resolutionDropdown.value = nativeResolutionIndex;
        resolutionDropdown.RefreshShownValue();
        resolutionDropdown.onValueChanged.AddListener(OnResolutionChanged);

    }

    // Método llamado cuando se cambia la resolución desde el menú desplegable
    public void OnResolutionChanged(int index)
    {
        Resolution[] resolutions = Screen.resolutions;
        List<Resolution> uniqueResolutions = new List<Resolution>();

        // Filtrar las resoluciones únicas
        foreach (Resolution resolution in resolutions)
        {
            string key = $"{resolution.width} x {resolution.height}";

            if (!uniqueResolutions.Contains(resolution) && !uniqueResolutions.Exists(r => r.width == resolution.width && r.height == resolution.height))
            {
                uniqueResolutions.Add(resolution);
            }
        }

        // Establecer la nueva resolución seleccionada
        if (index >= 0 && index < uniqueResolutions.Count)
        {
            bool isFullScreen;
            if (fullScreenToggle.isOn)
                isFullScreen = true;
            else
                isFullScreen = false;
            Resolution selectedResolution = uniqueResolutions[index];
            Screen.SetResolution(selectedResolution.width, selectedResolution.height, isFullScreen);
        }
    }
}
