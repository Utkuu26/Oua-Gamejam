using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Check : MonoBehaviour
{
    public bool canPressed;
    public KeyCode keyToPress;
    public int deletedArrow;
    public int totalArrow = 10;
    public bool arrowDeleted = false;

    public TextMeshProUGUI scoreText;
    public BeatScroller bs;

    

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

    void Start() 
    {
        //scoreText.text = "Score: " + deletedArrow + "/" + totalArrow;
    }

        
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
           if(canPressed)
           {
                gameObject.SetActive(false);
                bs.PlayNextSound();
                arrowDeleted = true;
                if(arrowDeleted)
                {
                    deletedArrow++;
                    scoreText.text = "Score: " + deletedArrow + "/" + totalArrow;
                    arrowDeleted = false;
                }
           }

           
        }
    }
}
