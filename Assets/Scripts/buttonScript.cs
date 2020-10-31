using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour
{
    public int maxSleep = 100;
    public int currentSleep = 0;
    float nextLower = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnMouseDown()
    {
        //if (Time.time > nextLower)
        //{
            nextLower = Time.time + UnityEngine.Random.Range(1, 10);
            Globals.sleep -= 5;
        //}
    }
}
