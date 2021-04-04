using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Wave
{
    public string waveName;
    public int NoOfEnemies;
    public GameObject[] typeOfEnemies;
    public float spawnInterval;

    public float timeBtwWave;
}

public class WaveSpawner : MonoBehaviour
{
   [SerializeField] Wave[] waves;
   public Transform spawnPoints;

   private Wave currentWave;
   private int currentWaveNumber;

   public bool canSpawn = true;

   private float nextSpawnTime;

   private float nextTimeBtwWave;

   public bool godfuckingdamnit;

   
void SpawnWave()
{
    if (canSpawn && nextSpawnTime < Time.time)
    {
    GameObject Enemy = currentWave.typeOfEnemies[0];
    Instantiate(Enemy, spawnPoints.position, Quaternion.identity);
    currentWave.NoOfEnemies--;
    nextSpawnTime = Time.time + currentWave.spawnInterval;
    if(currentWave.NoOfEnemies == 0)
    {
         canSpawn = false;
         godfuckingdamnit = true;
         
    }

    if (nextTimeBtwWave < Time.time)
    {
       
        currentWaveNumber++;
        canSpawn = true;
    }
    }
    
}

void Update()
{
    SpawnWave();

    if (godfuckingdamnit == true)
    {
        nextTimeBtwWave = Time.time + currentWave.timeBtwWave;
        godfuckingdamnit = false;
    }
   

}

void Start()
{
    currentWave = waves[currentWaveNumber];
}

        

   

}
