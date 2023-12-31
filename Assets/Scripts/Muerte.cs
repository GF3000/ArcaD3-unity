using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
    public GameObject gameOverMenu;

    public void Death()
    {
        if (PlayerPrefs.GetInt("Mode", 0) == 0)
        {
            Time.timeScale = 0f;
            gameOverMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
