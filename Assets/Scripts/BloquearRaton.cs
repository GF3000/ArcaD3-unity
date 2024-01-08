using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloquearRaton : MonoBehaviour
{
    public void Block()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
