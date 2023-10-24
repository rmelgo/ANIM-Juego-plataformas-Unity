using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    protected Rigidbody2D rigid;
    protected Transform trans;
    protected Collider2D collider2d;
    protected SpriteRenderer spriteRender;
    private IEnumerator corutina;
    private Vector3 posicionInicial;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        trans = GetComponent<Transform>();
        collider2d = GetComponent<Collider2D>();
        spriteRender = GetComponent<SpriteRenderer>();

        posicionInicial = trans.position;

        corutina = coroutinaAvisiones(10);
        StartCoroutine(corutina);
    }

    // Update is called once per frame
    void Update()
    {
        if (spriteRender.bounds.min.y < -4)
        {
            rigid.gravityScale = 0f;
            rigid.velocity = new Vector2(0, 0);
            //Destroy(this.gameObject);
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name.StartsWith("Jugador"))
        {
            rigid.gravityScale = 0.8f;
            collider2d.isTrigger = true;
        }
    }
    private IEnumerator coroutinaAvisiones(float waitTime)
    {
        while (true)
        {
            trans.position = posicionInicial;
            collider2d.isTrigger = false;
            yield return new WaitForSeconds(waitTime);
        }
    }
}
