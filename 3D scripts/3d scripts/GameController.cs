using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{

 public GameObject gameOverPanel;
 public GameObject taptoStart;
 public GameObject scoreText;
 public ParticleSystem rain;

    private void Start()
    {
      gameOverPanel.SetActive(false);
      taptoStart.SetActive(true);
      scoreText.SetActive(false);
      PauseGame();      
    }

   private void Update()
   {
       if (Input.GetKeyDown(KeyCode.Mouse0))
       {
           StartGame();
       }
   }
   
    public void GameOver()
    {
        scoreText.SetActive(false);
        gameOverPanel.SetActive(true);
    }
    public void Restart()
    {
       SceneManager.LoadScene("tanishk");
    }

     public void Quit()
    {
        Application.Quit();
    }
     public void PauseGame()
     {
        Time.timeScale = 0f;
     }
    public void StartGame()
     {
         taptoStart.SetActive(false);
         scoreText.SetActive(true);
         Time.timeScale = 1f;
     }
}
