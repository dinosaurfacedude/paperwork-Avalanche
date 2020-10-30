using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sleepScript : MonoBehaviour
{

    public Slider slider;

    public void setMaxSleep(int sleepLevel){

      slider.maxValue = sleepLevel;
      slider.value = sleepLevel;
    }


    public void setSleep(int sleepLevel){
    slider.value = sleepLevel;
    }
}
