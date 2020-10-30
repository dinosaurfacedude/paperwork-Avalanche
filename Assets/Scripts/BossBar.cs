using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossBar : MonoBehaviour

{
    public Slider slider;

    public void raiseWork(){
          slider.value = slider.value+1;
          if(slider.value == 20){
            SceneManager.LoadScene("gameOver");
          }
    }

    public void lowerWork()
    {
        slider.value = slider.value - 1;
    }
}
