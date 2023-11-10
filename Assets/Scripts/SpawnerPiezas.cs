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
    public int MAX_ALTO = 20
    public int ALTURA = 100
    public int INICIO_X = 5;
    public int INICIO_Y = 20;
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
        spawnPoints[0] = Random.Range(INICIO_X, MAX_ANCHO+INICIO_X);
        spawnPoints[1] = Random.Range(INICIO_Y, MAX_ALTO+INICIO_Y);
                // while (piezaActual == piezaAnterior)
        // {
        //     piezaActual = Random.Range(0, piezas.Length);
        // }

        Vector3 spawnPosition = new Vector3(spawnPoints[0], spawnPoints[1], ALTURA);
        piezaAnterior = piezaActual;
        Instantiate(piezas[piezaActual], spawnPosition, Quaternion.identity);
    }
}
