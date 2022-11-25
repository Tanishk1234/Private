 using System.Collections;

using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript playerScript;
    public Score score;
    public GameController gameController;
    public AudioSource audioSource;
    public AudioSource audioSourceGameOver;
    

   private void OnTriggerEnter(Collider other)
   {
       if (other.gameObject.tag =="Collectables")
       {
         audioSource.Play();
          score.AddScore(1);
          Destroy(other.gameObject);            
       }     
   }
   private void OnCollisionEnter(Collision other)
   {
       if (other.gameObject.tag == "Obstacles")
       {
           audioSourceGameOver.Play();
            gameController.GameOver();
          playerScript.enabled = false;
        }
    }
  }
