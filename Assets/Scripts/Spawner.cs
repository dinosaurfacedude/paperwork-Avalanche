using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject emailPrefab;
    float randX;
    float randY;
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
            randX = Random.Range(-7.75f, -0.75f);
            randY = Random.Range(-2.2f, 3.75f);
            whereToSpawn = new Vector2(randX, randY);
            GameObject a = Instantiate(emailPrefab) as GameObject;
            a.transform.position = whereToSpawn;
        }
    }

}
