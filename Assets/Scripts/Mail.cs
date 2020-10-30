using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mail : MonoBehaviour
{
    public string topic = "";
    // Start is called before the first frame update
    void Start()
    {
        int number = UnityEngine.Random.Range(1, 3);

        if (number == 1)
        {
            topic = "Wrench";
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
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name.Equals(topic));
        if(collision.gameObject.name.Equals(topic))
        {
            Destroy(this.gameObject);
        }
    }
}
