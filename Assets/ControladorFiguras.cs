using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ControladorFiguras : MonoBehaviour
{
    GameObject myPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/pieza1.fbx");

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(myPrefab, new Vector3(10, 10, 10), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
