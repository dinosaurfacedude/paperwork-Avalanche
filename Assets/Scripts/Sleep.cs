using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Sleep : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        slider.value = Globals.sleep;

        //if slider gets full, goes to exit screen
        if(slider.value == 100){
          SceneManager.LoadScene("gameOver");
        }
    }
}
