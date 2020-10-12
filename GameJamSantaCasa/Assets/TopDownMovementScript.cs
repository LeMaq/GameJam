using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovementScript : MonoBehaviour
{

    public float speed = 0.05f;
    public GameObject Player;
    public bool left;
    public bool right;
    public bool down;
    private bool IsMove;
    public bool up;
    private Vector3 vector;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //speed = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        // vector = Player.GetComponent<Rigidbody2D>().velocity;
        //Debug.Log("Velocidade" + Player.GetComponent<Rigidbody2D>().velocity);

        if (right || left || down || up)
        {
            animator.SetBool("IsMove", true);
        }
        else
        {

            animator.SetBool("IsMove", false);
        }


        if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("Directions", 1);

            if (!up && right && !left && !down)
            {
                speed = 0.05f;
            }
            transform.Translate(Vector2.right * speed, Space.World);
            right = true;
        }
        else if (Input.GetKey(KeyCode.D) == false)
        {
            right = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("Directions", 3);

            if (!up && !right && left && !down)
            {
                speed = 0.05f;
            }
            transform.Translate(Vector2.left * speed, Space.World);
            left = true;
        }
        else if (Input.GetKey(KeyCode.A) == false)
        {
            left = false;
        }

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetInteger("Directions", 2);


            if (!up && !right && !left && down)
            {
                speed = 0.05f;
            }
            transform.Translate(Vector2.down * speed, Space.World);

            down = true;
        }
        else if (Input.GetKey(KeyCode.S) == false)
        {
            down = false;
        }

        if (Input.GetKey(KeyCode.W))
        {

            animator.SetInteger("Directions", 4);

            if (up && !right && !left && !down)
            {
                speed = 0.05f;
            }
            transform.Translate(Vector2.up * speed, Space.World);
            up = true;
        }
        else if (Input.GetKey(KeyCode.W) == false)
        {
            up = false;
        }
        //if (up && right && !left && !down)
        //{
        //    speed = 0.025f;
        //    gameObject.transform.SetPositionAndRotation(transform.position, Quaternion.Euler(new Vector3(0, 0, 45)));
        //}
        //if (right && down && !up && !left)
        //{
        //    speed = 0.025f;
        //    gameObject.transform.SetPositionAndRotation(transform.position, Quaternion.Euler(new Vector3(0, 0, 315)));

        //}
        //if (down && left && !right && !up)
        //{
        //    speed = 0.025f;
        //    gameObject.transform.SetPositionAndRotation(transform.position, Quaternion.Euler(new Vector3(0, 0, 225)));
        //    Debug.LogWarning("vai");

        //}
        //if (left && up && !right && !down)
        //{
        //    speed = 0.025f;
        //    gameObject.transform.SetPositionAndRotation(transform.position, Quaternion.Euler(new Vector3(0, 0, 135)));

        //}


        //asdhiasdg
        if (up && !right && !left && !down)
        {

            //gameObject.transform.SetPositionAndRotation(transform.position, Quaternion.Euler(new Vector3(0, 0, 90)));
        }
        if (!up && right && !left && !down)
        {
            //gameObject.transform.SetPositionAndRotation(transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));

        }
        if (!up && !right && left && !down)
        {
            // gameObject.transform.SetPositionAndRotation(transform.position, Quaternion.Euler(new Vector3(0, 0, 180)));



        }
        if (!up && !right && !left && down)
        {
            // gameObject.transform.SetPositionAndRotation(transform.position, Quaternion.Euler(new Vector3(0, 0, 270)));

        }


    }


}
