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

    public int MAX_ANCHO = 10;
    public int MAX_ALTO = 20;
    public int ALTURA = 100;
    public float olguraAltura = 0f;
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

    public void Spawn()
    {

        piezaActual = Random.Range(0, piezas.Length);
        // piezaActual = 2;
    
       
        piezaAnterior = piezaActual;
        
          int rotationY = Random.Range(0, 4) * 90; // Rotación en el eje Y
        int rotationZ = Random.Range(0, 4) * 90; // Rotación en el eje Z
        int rotationX = Random.Range(0, 4) * 90; // Rotación en el eje X

        Vector3 spawnPosition = newSpawnPosition();


        GameObject objetoPieza = Instantiate(piezas[piezaActual], spawnPosition,  Quaternion.Euler(rotationX, rotationY, rotationZ));
        // Debug.Log("Spawned, isTouchingWall: " + objetoPieza.GetComponent<CaidaPiezas>().get_isTouchingWall() + " isTouchingFloor: " + objetoPieza.GetComponent<CaidaPiezas>().get_isTouchingFloor() + "");
        while (objetoPieza.GetComponent<CaidaPiezas>().get_isTouchingWall() || objetoPieza.GetComponent<CaidaPiezas>().get_isTouchingFloor())
        {
            Debug.Log("Spawning again");
            Destroy(objetoPieza);
            spawnPosition = newSpawnPosition();
            objetoPieza = Instantiate(piezas[piezaActual], spawnPosition,  Quaternion.Euler(rotationX, rotationY, rotationZ));
        }

 
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


