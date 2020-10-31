using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newGame : MonoBehaviour
{
    // Start is called before the first frame update
    void OnMouseDown(){
      Globals.sleep = 0;
      Globals.bossInt = 0;
      SceneManager.LoadScene("Gameplay");
    }
}
