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
<<<<<<< HEAD
=======

>>>>>>> 1ba210a319e6f6da343a24c64ead050a3abab63d
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
