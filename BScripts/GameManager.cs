using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.ParticleSystemJobs;
public class GameManager : MonoBehaviour
{

    private AudioManager audioManager;
    public GameObject audmag;
    public GameObject WinPanel;
    public ParticleSystem rainParicle;
    private VideoManger videoManager;
    public GameObject videomanger;
    public GameObject pauseButton;
    public GameObject pausemenu;
    private float currentTime;
    public float  startingTime = 10f;
    public Text countDownText;
    public GameObject gameoverPanel;
    private int score = 0;
    public float scoreTowin; 
    private void Awake()
    {
        //settingManager = SM.GetComponent<SettingManager>();
        videoManager = videomanger.GetComponent<VideoManger>();
        audioManager = audmag.GetComponent<AudioManager>();
    }
    private void Start()
    {
        WinPanel.SetActive(false);
        audioManager.GameStartAudio.Play();
        audioManager.GameOverAudio.Stop();
        audioManager.GameWinAudio.Stop();
        currentTime = startingTime;
        pausemenu.SetActive(false);
        pauseButton.SetActive(true);
        gameoverPanel.SetActive(false);
        videoManager.GameOverVideo.Pause();
        videoManager.YouWinVideo.Pause();
        videoManager.LevelVideo.Play();
        videoManager.PauseVideo.Pause();
        videoManager.VideoPause.SetActive(false);
        videoManager.LevelPlayer.SetActive(true);
        videoManager.VideoOver.SetActive(false);
        videoManager.VideoWin.SetActive(false);
        rainParicle.Play();
    }
    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = "" + currentTime.ToString("00");
        if (currentTime <= 0)
        {
           currentTime = 0;
           gameoverPanel.SetActive(true);
           rainParicle.Stop();
           WinPanel.SetActive(false);
           audioManager.GameStartAudio.Stop();
           audioManager.GameOverAudio.Play();
           audioManager.GameWinAudio.Stop();
           videoManager.VideoPause.SetActive(false);
           videoManager.LevelPlayer.SetActive(false);
           videoManager.VideoOver.SetActive(true);
           videoManager.VideoWin.SetActive(false);
           videoManager.GameOverVideo.Play();
           videoManager.YouWinVideo.Pause();
           videoManager.LevelVideo.Pause();
           videoManager.PauseVideo.Pause();
           pauseButton.SetActive(false);
           Time.timeScale = 0f;
          
        }
    }
    public void pauseGame()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        WinPanel.SetActive(false);
        pauseButton.SetActive(false);
        videoManager.VideoPause.SetActive(true);
        videoManager.LevelPlayer.SetActive(false);
        videoManager.VideoOver.SetActive(false);
        videoManager.VideoWin.SetActive(false);
        videoManager.PauseVideo.Play();
        videoManager.LevelVideo.Pause();
        videoManager.GameOverVideo.Pause();
        videoManager.YouWinVideo.Pause();
        rainParicle.Stop();
 
    }
    public void ResumeGame()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        WinPanel.SetActive(false);
        pauseButton.SetActive(true);
        videoManager.VideoPause.SetActive(false);
        videoManager.LevelPlayer.SetActive(true);
        videoManager.VideoOver.SetActive(false);
        videoManager.VideoWin.SetActive(false);
        videoManager.LevelVideo.Play();
        Time.timeScale = 1f;
        videoManager.PauseVideo.Pause();
        videoManager.YouWinVideo.Pause();
        videoManager.GameOverVideo.Pause();
        rainParicle.Play();
    
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ScoreUp()
    {
        score++;
        if(score >= scoreTowin)
        {
            WinTheGame();
        }
    }
    public void  WinTheGame()
    {
        WinPanel.SetActive(true);
        Time.timeScale = 0f;
        pauseButton.SetActive(false);
    }

}