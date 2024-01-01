using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dificultad : MonoBehaviour
{
    public TMP_Dropdown resolutionDropdown;

    void Start()
    {
        resolutionDropdown.value = PlayerPrefs.GetInt("Mode", 0);
        resolutionDropdown.RefreshShownValue();
        resolutionDropdown.onValueChanged.AddListener(OnDifficultyChanged);
    }
    
    public void OnDifficultyChanged(int index)
    {
        PlayerPrefs.SetInt("Mode", index);
        PlayerPrefs.Save();
    }
}
