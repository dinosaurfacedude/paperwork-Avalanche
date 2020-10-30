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

    GameObject boss = GameObject.Find("bossbarUI");

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
            bossBar.raiseWork();
        }
        else if (number == 2)
        {
            topic = "Water";
            spriteRenderer.sprite = waterSprite;
            bossBar.raiseWork();
        }
        else
        {
            topic = "Elect";
            spriteRenderer.sprite = electSprite;
            bossBar.raiseWork();
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
        if(collision.gameObject.name.Equals(topic))
        {
            bossBar.lowerWork();
            Destroy(this.gameObject);
        }
    }
}
