using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pausa : MonoBehaviour
{
    public List<Button> buttons = new List<Button>();
    public GameObject menuPausa;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        menuPausa.SetActive(false);
    }

    void OnEnable()
    {
        foreach (var button in buttons)
        {
            button.interactable = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("pausa");
            Time.timeScale = 0f;
            menuPausa.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        menuPausa.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
