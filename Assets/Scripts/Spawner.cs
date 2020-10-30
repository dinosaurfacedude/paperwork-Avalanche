using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject emailPrefab;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0;

    int randEnemy;

    void Start()
    {
        
    }

    void Update()
    {
       if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-8.4f, 8.4f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            GameObject a = Instantiate(emailPrefab) as GameObject;
            a.transform.position = whereToSpawn;
        }
    }

}
