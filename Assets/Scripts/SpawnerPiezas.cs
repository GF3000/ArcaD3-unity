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
    public float olguraAltura = 5f;
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
        // piezaActual = 2;
    
       
        Vector3 spawnPosition = newSpawnPosition();
        piezaAnterior = piezaActual;
        // Instantiate a pieza, if it´s touching a wall, destroy it and instantiate another one
        // Instantiate(piezas[piezaActual], spawnPosition, Quaternion.identity);
        // Debug.Log("Spawning " + piezas[piezaActual].name + " at " + spawnPosition + "is touching wall: " + piezas[piezaActual].GetComponent<CaidaPiezas>().isTouchingWall(spawnPosition));
        
        // //Print piezas[piezaActual].GetComponent<CaidaPiezas>() in the console to see if it has a CaidaPiezas component
        // while (piezas[piezaActual].GetComponent<CaidaPiezas>().isTouchingWall(spawnPosition))
        // {
        //     spawnPosition = newSpawnPosition();
        // }

        Instantiate(piezas[piezaActual], spawnPosition, Quaternion.identity);

 
    }

    Vector3 newSpawnPosition()
    {
        int alturaGeneracion = ALTURA + (int)Random.Range(-olguraAltura, olguraAltura);
        int[] spawnPoints = new int[2];
        spawnPoints[0] = (int)Random.Range(-(MAX_ANCHO/2+INICIO_X), MAX_ANCHO/2+INICIO_X);
        spawnPoints[1] = (int)Random.Range(-(MAX_ALTO/2+INICIO_Y), MAX_ALTO/2+INICIO_Y);
        Vector3 spawnPosition = new Vector3(spawnPoints[0], alturaGeneracion, spawnPoints[1]);
        return spawnPosition;
    }
}


