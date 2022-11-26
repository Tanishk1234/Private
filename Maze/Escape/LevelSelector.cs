using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public Button[] levelButton;

     void Start()
     {
         foreach (Button b in levelButton)
         {
             b.interactable = false;
             int reachLevel1 = PlayerPrefs.GetInt("ReachLevel1", 1);

             for (int i = 0; i < reachLevel1; i++)
                 levelButton[i].interactable = true;
         }
    }
}
