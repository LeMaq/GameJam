using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovementScript : MonoBehaviour
{

    public float speed = 0.05f;
    public GameObject bonequinho;
    public bool left;
    public bool right;
    public bool down;
    public bool up;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.D))
        {
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
        if (up && right && !left && !down)
        {
            speed = 0.025f;
            gameObject.transform.SetPositionAndRotation(transform.position, Quaternion.Euler(new Vector3(0, 0, 45)));
        }
        if (right && down && !up && !left)
        {
            speed = 0.025f;
            gameObject.transform.SetPositionAndRotation(transform.position ,Quaternion.Euler(new Vector3(0,0,315)));

        }
        if (down && left && !right && !up)
        {
            speed = 0.025f;
            gameObject.transform.SetPositionAndRotation(transform.position, Quaternion.Euler(new Vector3(0, 0, 225)));
            Debug.LogWarning("vai");

        }
        if (left && up && !right && !down)
        {
            speed = 0.025f;
            gameObject.transform.SetPositionAndRotation(transform.position, Quaternion.Euler(new Vector3(0, 0, 135)));

        }
        //asdhiasdg
        if (up && !right && !left && !down)
        {
            gameObject.transform.SetPositionAndRotation(transform.position, Quaternion.Euler(new Vector3(0, 0, 90)));
        }
        if (!up && right && !left && !down)
        {
            gameObject.transform.SetPositionAndRotation(transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));

        }
        if (!up && !right && left && !down)
        {
            gameObject.transform.SetPositionAndRotation(transform.position, Quaternion.Euler(new Vector3(0, 0, 180)));
            Debug.LogWarning("vai");

        }
        if (!up && !right && !left && down)
        {
            gameObject.transform.SetPositionAndRotation(transform.position, Quaternion.Euler(new Vector3(0, 0, 270)));

        }


    }


}
