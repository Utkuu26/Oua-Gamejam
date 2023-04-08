using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    public bool canPressed;
    public KeyCode keyToPress;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Activator")
        {
            canPressed = true;
        }    
    }

    private void OnTriggerExit(Collider other) 
    {
        if(other.tag == "Activator")
        {
            canPressed = false;
        }    
    }

    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            if(canPressed)
            {
                gameObject.SetActive(false);
            }
        }
    }
    
}
