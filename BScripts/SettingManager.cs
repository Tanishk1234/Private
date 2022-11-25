using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SettingManager : MonoBehaviour
{

  public GameObject ExitButton;
  public GameObject SettingPanel;
  public Image VideoOn;
  public Image VideoOff;
  public Image RainOn;
  public Image RainOff;
  public GameObject VideoPlayer;
  public GameObject RainPlayer;
  int Videoindex;
  int RainIndex;

   void Start()
     {
        SettingPanel.SetActive(false);
        ExitButton.SetActive(false);
    }
   void Update()
  {
      if(Videoindex == 1)
      {
        VideoPlayer.SetActive(false);
      } 

      if(Videoindex == 0)
      {
        VideoPlayer.SetActive(true);
      } 
      if(RainIndex == 1)
      {
        RainPlayer.SetActive(false);
      } 

      if(RainIndex == 0)
      {
        RainPlayer.SetActive(true);
      } 
  
  }

  public void VideoON() 
  {
       Videoindex = 1;
       VideoOff.gameObject.SetActive(true);
       VideoOn.gameObject.SetActive(false);
  }

public void VideoOFF()
{
    Videoindex = 0;
    VideoOff.gameObject.SetActive(false);
    VideoOn.gameObject.SetActive(true);
}
  public void RainON() 
  {
       RainIndex = 1;
       RainOff.gameObject.SetActive(true);
       RainOn.gameObject.SetActive(false);
  }

public void RainOFF()
{
    RainIndex = 0;
    RainOff.gameObject.SetActive(false);
    RainOn.gameObject.SetActive(true);
}
    
    public void Exit()
  {
    SettingPanel.SetActive(false);
    ExitButton.SetActive(false);
  }

  public void SettingManger()
  {
    SettingPanel.SetActive(true);
    ExitButton.SetActive(true);
  }
}
