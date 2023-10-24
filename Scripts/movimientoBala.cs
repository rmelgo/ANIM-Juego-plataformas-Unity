using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoBala : MonoBehaviour
{
    public float velocidad = 1.0f;
    protected Rigidbody2D rigid;
    protected static Transform trans;
    protected SpriteRenderer spriteRender;
    public static GameObject prefabBala;


    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        trans = GetComponent<Transform>();
        if (trans.rotation == Quaternion.identity)
        {
            rigid.velocity = new Vector2(velocidad, 0);
        }
        else
        {
            rigid.velocity = new Vector2(0, -velocidad);
        }
        spriteRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Suelo")
        {
            Destroy(this.gameObject);
        }
    }
}