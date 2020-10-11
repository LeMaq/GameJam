using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float Life;
    private float CurrentLife;
    public GameObject lanterna;
    public int pilhas;
    private float TimeDuration;
    public float PilhaDuration;
      
    // Start is called before the first frame update
    void Start()
    {
        CurrentLife = Life;


    }


   


    private void OnTriggerEnter2D(Collider2D collision)
    {


        //if (collision.gameObject.CompareTag("Battery"))
        //{
        //    pilhas++;
        //    Destroy(collision.gameObject);
        //}

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Levou dano");

            CurrentLife -= 10;
            if (CurrentLife<=0) {
                Destroy(gameObject);
            }
        }
        
    }



            void Update()
    {

        if (lanterna.active) { 
                TimeDuration -= Time.deltaTime;
        }

        if (TimeDuration <= 0) {
            if (pilhas > 0)
            {
                pilhas--;
                TimeDuration = PilhaDuration;

                Debug.Log("Regarregou");
            }
            else {
                lanterna.SetActive(false);
            }
        }

        if (Input.GetKeyDown("space")) {
            if (TimeDuration > 0 ) { 
               lanterna.SetActive(!lanterna.active);
            }
        }

    }
}
