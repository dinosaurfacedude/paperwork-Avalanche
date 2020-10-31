using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BossBar : MonoBehaviour
{
    public Slider slider;

    public void Start()
    {

    }
    public void Update()
    {
        slider.value = Globals.bossInt;
        if(slider.value == 100){
          SceneManager.LoadScene("gameOver");
        }
    }

}
