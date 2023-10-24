using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{
    public float velocidad = 5f;
    public float salto = 15f;
    protected Rigidbody2D rigidBody2D;
    protected Animator animator;
    protected Collider2D collider2d;
    public int dobleSalto;
    AudioSource audioSource;
    private Vector3 posicionInicial;
    public GameObject text;

    // Use this for initialization
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        collider2d = GetComponent<Collider2D>();
        audioSource = GetComponent<AudioSource>();
        dobleSalto = 2;
        posicionInicial = transform.position;
        text = GameObject.Find("Text");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && dobleSalto > 0 && !animator.GetBool("muerte"))
        {
            Debug.Log(rigidBody2D.velocity.y);
            rigidBody2D.AddForce(new Vector2(0, (salto * 2) - rigidBody2D.velocity.y), ForceMode2D.Impulse);
            Debug.Log("SAlto " + Time.time);
            dobleSalto = dobleSalto - 1;
        }
    }

    void FixedUpdate()
    {
        if (!animator.GetBool("muerte"))
        {
            rigidBody2D.velocity = new Vector2(velocidad * Input.GetAxis("Horizontal"), rigidBody2D.velocity.y);
            animator.SetBool("correr", rigidBody2D.velocity.x != 0);

            //roto al personaje para es lo escalo a -1 o lo giro 180 en el eje y
            if (rigidBody2D.velocity.x < 0)
                transform.rotation = Quaternion.Euler(0, 180, 0);
            else if (rigidBody2D.velocity.x > 0)
                transform.rotation = Quaternion.Euler(0, 0, 0);

            //saltar arriba
            if (rigidBody2D.velocity.y > 0 && Physics2D.OverlapBox(transform.GetChild(0).position, new Vector2((collider2d.bounds.max.x - collider2d.bounds.min.x) / 2f, 0.01f), 0) == null)
            {
                animator.SetBool("saltar", true);
                if (animator.GetBool("caer"))
                {
                    animator.SetBool("caer", false);
                }
            }

            //cayendo
            else if (rigidBody2D.velocity.y < 0 && animator.GetBool("saltar"))
            {
                animator.SetBool("saltar", false);
                animator.SetBool("caer", true);
            }

            //toco tierra
            else if (animator.GetBool("caer") && Physics2D.OverlapBox(transform.GetChild(0).position, new Vector2((collider2d.bounds.max.x - collider2d.bounds.min.x) / 2f, 0.01f), 0) != null)
            {
                animator.SetBool("saltar", false);
                animator.SetBool("caer", false);
                animator.SetTrigger("caerTierra");
                dobleSalto = 2;
            }

            //el overlapbox se hace la mitad del collider para evitar que roce en lateral con una plataforma y me deje saltar de nuevo, (collider2d.bounds.max.x - collider2d.bounds.min.x) / 2
            if (Physics2D.OverlapBox(transform.GetChild(0).position, new Vector2((collider2d.bounds.max.x - collider2d.bounds.min.x) / 2f, 0.01f), 0) != null)
            {
                //Debug.Log("SAlto " + Time.time);
                if (Input.GetAxis("Jump") != 0)
                {
                    rigidBody2D.AddForce(new Vector2(0, salto), ForceMode2D.Impulse);
                    Debug.Log("SAlto " + Time.time);
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pinchos" && !animator.GetBool("muerte")) 
        {
            audioSource.Play();
            animator.SetBool("muerte", true);
            animator.SetTrigger("morir");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bala" && !animator.GetBool("muerte"))
        {
            Animator animator = GetComponent<Animator>();
            animator.SetBool("muerte", true);
            animator.SetTrigger("morir");
            Destroy(other.gameObject);
        }

        if (other.gameObject.name.StartsWith("Sierra") && !animator.GetBool("muerte"))
        {
            animator.SetBool("muerte", true);
            animator.SetTrigger("morir");
        }
    }

    public void recolocar()
    {
        animator.SetBool("muerte", false);
        animator.SetTrigger("reinicio");
        rigidBody2D.velocity = Vector3.zero;
        transform.position = posicionInicial;

        Muertes.pMuertes += 1;
        text.GetComponent<Text>().text = "Muertes: " + Muertes.pMuertes;
    }
}
