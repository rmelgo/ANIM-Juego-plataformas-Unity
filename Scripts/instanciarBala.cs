using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciarBala : MonoBehaviour
{
    protected Transform trans;
    public GameObject prefabBala;
    private IEnumerator corutina;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        trans = GetComponent<Transform>();
        audioSource = GetComponent<AudioSource>();

        corutina = coroutinaAvisiones(2);
        StartCoroutine(corutina);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator coroutinaAvisiones(float waitTime)
    {
        while (true)
        {
            if (trans.gameObject.tag == "Abajo")
            {
                audioSource.Play();
                Instantiate(prefabBala, new Vector2(trans.GetChild(0).position.x, trans.GetChild(0).position.y), Quaternion.Euler(0, 0, 270));
            }
            else
            {
                audioSource.Play();
                Instantiate(prefabBala, new Vector2(trans.GetChild(0).position.x, trans.GetChild(0).position.y), Quaternion.identity);
            }
            yield return new WaitForSeconds(waitTime);
        }
    }
}