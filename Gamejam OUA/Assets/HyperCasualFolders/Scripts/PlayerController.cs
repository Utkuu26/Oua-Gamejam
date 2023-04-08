using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 
    public float runningSpeed;
    float touchXDelta = 0;
    float newX = 0;
    public float XSpeed;
    public float limitx;

    void Start()
    {

    }


    void Update()
    {
        SwipeCheck();
    }
    private void SwipeCheck()
    {
        
        if (Input.GetAxis("Horizontal") != 0)
        {
            //Debug.Log(Input.GetAxis("Horizontal"));
            touchXDelta = Input.GetAxis("Horizontal") / (Screen.width * 10);
            newX = transform.position.x + XSpeed * touchXDelta + Time.deltaTime;
            newX = Mathf.Clamp(newX, -limitx, limitx);
        }

       


        Vector3 newPosition = new Vector3(newX, transform.position.y, transform.position.z + runningSpeed * Time.deltaTime);
        transform.position = newPosition;
    }
}
