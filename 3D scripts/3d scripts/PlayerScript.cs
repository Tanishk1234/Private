using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
   public Rigidbody rigidbody; 
   public float speedX;
   public float force;
   public float maxX;
   public float minX; 

    void Update()
    {
     
     Vector3 playerPos = transform.position;
     if (playerPos.x<minX)

     {
         playerPos.x = minX;
     }

     if (playerPos.x>maxX)

     {
         playerPos.x = maxX;
     }

     transform.position = playerPos;       
      
     
     if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D))
     {
         transform.position = transform.position + new Vector3(speedX * Time.deltaTime,0 , 0);
     }

     if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A))
     {
          transform.position = transform.position - new Vector3(speedX * Time.deltaTime,0 , 0);
     }
       
    }
    private void FixedUpdate()
    {
          rigidbody.AddForce(0, 0, force * Time.deltaTime);
    }
}
