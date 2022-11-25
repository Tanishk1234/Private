using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Button = UnityEngine.UI.Button;
using UnityEngine.SceneManagement;
public class Balls : MonoBehaviour
{
    public AudioSource BallDestroyAudio;
    private void OnMouseDown()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().ScoreUp();
        Destroy(gameObject);
        BallDestroyAudio.Play();
    }
}
