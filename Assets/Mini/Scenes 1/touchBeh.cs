using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class touchBeh : MonoBehaviour
{
    private Touch touch;
    public float speed;
    string message; 
    string display;
    private void Start()
    {
        speed = 0.01f;
    }
    void Update()
    {
        if (Input.touchCount> 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x * speed,
                    transform.position.y,
                    transform.position.z + touch.deltaPosition.y * speed);
            }
        }              
    }
}

/*
 * void update()
{
    

    if (Input.touchCount > 0)
    {
        Touch touch = Input.GetTouch(0);

        switch (touch.phase)
        {
            case TouchPhase.Began:
                
            case Touchphase.Moved:
               
                break;
            case TouchPhase.Ended:
               
                break;
        }
    }
}
}
*/


