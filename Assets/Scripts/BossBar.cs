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
        slider.value = Globals.bossInt;
    }

}
