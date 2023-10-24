using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sierra : MonoBehaviour
{
    public float velocidad = 1.0f;
    protected Rigidbody2D rigid;
    protected static Transform trans;
    protected SpriteRenderer spriteRender;
    public GameObject sierra;
    AudioSource audioSource;

    float x;

    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        trans = GetComponent<Transform>();
        spriteRender = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();

        if (sierra.name.StartsWith("Sierra2"))
        {
            rigid.velocity = new Vector2(0, velocidad);
        }
        else
        {
            rigid.velocity = new Vector2(velocidad, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (sierra.name.StartsWith("Sierra2"))
        {
            x += Time.deltaTime * 100;
            sierra.transform.rotation = Quaternion.Euler(0, 0, x);

            if (sierra.transform.position.y >= 7)
            {
                rigid.velocity = new Vector2(0, -velocidad);
            }
            if (sierra.transform.position.y <= -3)
            {
                rigid.velocity = new Vector2(0, velocidad);
            }
        }
        else
        {
            x += Time.deltaTime * 100;
            sierra.transform.rotation = Quaternion.Euler(0, 0, x);

            if (sierra.transform.position.x >= 24)
            {
                rigid.velocity = new Vector2(-velocidad, 0);
            }
            if (sierra.transform.position.x <= 0)
            {
                rigid.velocity = new Vector2(velocidad, 0);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.StartsWith("Jugador"))
        {
            audioSource.Play();
        }
    }
}
