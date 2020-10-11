using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Password : MonoBehaviour
{
    private string password = "a4z";
    public InputField playerInput;
    public string USERINPUT;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void CheckPassword ()
    {
        USERINPUT = playerInput.text;

        if (USERINPUT != null)
        {
            if (USERINPUT == password)
            {
                Debug.Log("ta certo");
            }
            else
            {
                Debug.Log("ta errado");
            }
        }
    }
}
