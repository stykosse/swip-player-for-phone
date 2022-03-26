using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class swipplayer : MonoBehaviour
{
public Rigidbody rb;
  
   public float forwardForce = 1000f;
   GameObject player;
   

  

    void Update()
    {
          rb.AddForce(0, 0, forwardForce * Time.deltaTime);
                if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speed, 
                    transform.position.y, transform.position.z);
            }
        }
          

       
    }
   
}
