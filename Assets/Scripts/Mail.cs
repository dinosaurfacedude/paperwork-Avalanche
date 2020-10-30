using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mail : MonoBehaviour
{
    public string topic = "";
    public SpriteRenderer spriteRenderer;
    public Sprite itSprite;
    public Sprite waterSprite;
    public Sprite electSprite;
    public int layer;

    public BossBar bossBar;
    public buttonScript myButton;

    public Mail(BossBar b)
    {
        bossBar = b;
    }
    // Start is called before the first frame update
    void Start()
    {
        int number = UnityEngine.Random.Range(1, 4);
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        layer = UnityEngine.Random.Range(0, 3);
        this.spriteRenderer.sortingOrder = layer;
        if (number == 1)
        {
            topic = "Wrench";
            spriteRenderer.sprite = itSprite;
        }
        else if (number == 2)
        {
            topic = "Water";
            spriteRenderer.sprite = waterSprite;
        }
        else
        {
            topic = "Elect";
            spriteRenderer.sprite = electSprite;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (UnityEngine.Random.Range(1, 100) % 6 == 0)
        {
            Globals.bossInt = Globals.bossInt + 0.01f;
            Debug.Log(Globals.bossInt);
        }
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
        if(collision.gameObject.name.Equals(topic))
        {
            //      bossBar.lowerWork();
            // myButton.gainSleep(15);
            if (Globals.bossInt < 1)
            {
                Globals.bossInt = 0;
            }
            else
            {
                Globals.bossInt = Globals.bossInt - 1;
            }
            Debug.Log(Globals.bossInt);
            Destroy(this.gameObject);
        }
    }
}
