using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class BossBar : MonoBehaviour
{
    public Slider slider;

    public void Start()
    {
        
    }
    public void Update()
    {
        if (UnityEngine.Random.Range(1, 100) % 25 == 0)
        {
            slider.value = slider.value+1;
        }
    }

    public void lowerWork()
    {
        slider.value = slider.value - 1;
    }

}
