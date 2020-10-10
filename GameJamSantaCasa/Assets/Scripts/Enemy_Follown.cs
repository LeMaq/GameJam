using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy_Follown : MonoBehaviour
{
    public float speed;
    private bool LightInside;
    private float TimePassed;
    private Transform target;
    public float lineOfsite; // distancia para perceber o player
    public float StopDistance; // dintancia para parar de atacar o player
    public GameObject bullet;
    public GameObject bulletParent;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.gameObject.CompareTag("Luz"))
        {

            LightInside = true;
            TimePassed = 0f;

            Debug.Log("Colidiu -- luz");
        }
        

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        // Debug.Log("Colidiu -- "+ collision.gameObject.tag);

        if (collision.gameObject.CompareTag("Luz"))
        {

            LightInside = false;

           
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (LightInside) {
            TimePassed += Time.deltaTime;
            if (TimePassed >= 3) {
                Destroy(gameObject);
            }
        }

        float DistanceFromPlayer = Vector2.Distance(target.position, transform.position);

        if (DistanceFromPlayer < lineOfsite && DistanceFromPlayer > StopDistance) { 

                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
                
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfsite);
        Gizmos.DrawWireSphere(transform.position, StopDistance);

    }


}
