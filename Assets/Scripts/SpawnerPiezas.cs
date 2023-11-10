using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPiezas : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] piezas;
    public float spawnTime = 5f;
    public int[] spawnPoints;
    public int piezaActual = 0;
    public int piezaAnterior = 0;

    public int NUM_PIEZAS = 7;
    public int MAX_ANCHO = 10;
    public int MAX_ALTO = 20;
    public int ALTURA = 100;
    public float INICIO_X = 5;
    public float INICIO_Y = 20;
     //Create a final public var
    public static SpawnerPiezas instance;
    void Start()
    {
        spawnPoints = new int[2];
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        // Initialize spawnPoints

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {

        piezaActual = Random.Range(0, piezas.Length);
    
        spawnPoints[0] = (int)Random.Range(-(MAX_ANCHO/2+INICIO_X), MAX_ANCHO/2+INICIO_X);
        spawnPoints[1] = (int)Random.Range(-(MAX_ALTO/2+INICIO_Y), MAX_ALTO/2+INICIO_Y);
                // while (piezaActual == piezaAnterior)
        // {
        //     piezaActual = Random.Range(0, piezas.Length);
        // }

        Vector3 spawnPosition = new Vector3(spawnPoints[0], ALTURA, spawnPoints[1]);
        piezaAnterior = piezaActual;
        Instantiate(piezas[piezaActual], spawnPosition, Quaternion.identity);

        //Make a console message so we know it's working
        Debug.Log("Spawning " + piezas[piezaActual].name + " at " + spawnPosition);

    }
}
