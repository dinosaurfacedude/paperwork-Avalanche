using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(BoxCollider2D))]
public class Mail : MonoBehaviour
{
    public string emailTopic;
    // Start is called before the first frame update
    void Start()
    {
        int number = UnityEngine.Random.Range(1, 3);

        if (number == 1)
        {
            emailTopic = "Wrench";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    private Vector3 screenPoint;
    private Vector3 offset;

    void OnMouseDown()
    {
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        SceneManager.LoadScene("Untitled");
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
}
