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
    private BoxCollider2D Player;
    private Rigidbody2D rbdPlayer;
    public float lineOfsite; // distancia para perceber o player
    public float StopDistance; // dintancia para parar de atacar o player
    public GameObject bullet;
    public GameObject bulletParent;
    bool can_atack = true;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<BoxCollider2D>();
        rbdPlayer = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Rigidbody2D>();
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
            if (TimePassed >= 2) {
                Destroy(gameObject);
            }
        }

        float DistanceFromPlayer = Vector2.Distance(target.position, transform.position);

        if (DistanceFromPlayer < lineOfsite && DistanceFromPlayer > StopDistance)
        {

            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        }
        else if (DistanceFromPlayer <= StopDistance && can_atack)
        {

            if (can_atack) {  
                can_atack = false;
                Atack();
            }
            
        }
        else
        {
                Player.isTrigger = false;
        }

    }


    private void Check_Bool() {
        can_atack = true;
        rbdPlayer.velocity = Vector3.zero;
    }

    private void Atack() {


        can_atack = false;
        Player.isTrigger = false;
        Debug.Log("Atacou");
        Vector3 dir = (transform.position - target.position).normalized;
        rbdPlayer.AddForce(dir * -1000f);
        Invoke("Check_Bool", 0.5f);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfsite);
        Gizmos.DrawWireSphere(transform.position, StopDistance);

    }


}
