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

    public float speed3;

    
}

public class WaveSpawner : MonoBehaviour
{
   [SerializeField] Wave[] waves;
   public Transform spawnPoints;

   private Wave currentWave;
   private int currentWaveNumber;

   public bool canSpawn = true;

   private float nextSpawnTime;

   public float nextTimeBtwWave;

   public bool godfuckingdamnit = false;

    public AudioSource audioSource;

    public AudioClip drum;

    public Timing timing1;

    public Animator helpme;

   
void SpawnWave()
{
    if (canSpawn && nextSpawnTime < Time.time)
    {
    GameObject Enemy = currentWave.typeOfEnemies[0];
    Instantiate(Enemy, spawnPoints.position, Quaternion.identity);
    currentWave.NoOfEnemies--;
    nextSpawnTime = Time.time + currentWave.spawnInterval;
    StartCoroutine("poggers");
    if(currentWave.NoOfEnemies == 0)
    {
         canSpawn = false;
         godfuckingdamnit = true;
         
    }

   
    }
    
}

void Update()
{
    SpawnWave();


    

    if (!canSpawn && godfuckingdamnit == true)
    {
        nextTimeBtwWave = currentWave.timeBtwWave -= Time.deltaTime * timing1.speed;


    }

   
    if (nextTimeBtwWave < 0 && !canSpawn)
    {

        godfuckingdamnit = false;
        nextTimeBtwWave = currentWave.timeBtwWave;
        currentWaveNumber++;
        canSpawn = true;
        
    
    }

    currentWave = waves[currentWaveNumber];

    timing1.speed2 = currentWave.speed3;

}

void Start()
{
    currentWave = waves[currentWaveNumber];
    nextTimeBtwWave = currentWave.timeBtwWave;
    timing1 = GameObject.FindObjectOfType<Timing>();

}

IEnumerator poggers()
{
       yield return new WaitForSeconds(0.01f);
       audioSource.PlayOneShot(drum);
}

        

   

}
