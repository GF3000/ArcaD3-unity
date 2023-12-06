using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabezaScript : MonoBehaviour
{
    public Transform FirstPersonController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FirstPersonController != null)
        {
            // Establecer la posición del objeto seguidor como la posición del objeto a seguir
            transform.position = FirstPersonController.position;
            transform.rotation = FirstPersonController.rotation;
            
            transform.position = new Vector3(FirstPersonController.position.x, FirstPersonController.position.y + 0.8f, FirstPersonController.position.z);
        }
    }
}
