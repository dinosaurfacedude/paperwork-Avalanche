using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour
{
    public int maxSleep = 100;
    public int currentSleep = 0;
    public sleepScript mySleep;
    // Start is called before the first frame update
    void Start()
    {
        currentSleep = 0;
        mySleep.setMaxSleep(maxSleep);
        mySleep.setMaxSleep(currentSleep);
    }

    // Update is called once per frame
    void OnMouseDown(){
      loseSleep(5);
    }

    void loseSleep(int Sleep){
      currentSleep -= Sleep;
      mySleep.setSleep(Sleep);
    }

    public void gainSleep(int Sleep){
      currentSleep += Sleep;
      mySleep.setSleep(Sleep);
    }
}
