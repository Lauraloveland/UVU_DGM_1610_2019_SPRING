using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ScoreManagment; 
public class MainMenu : MonoBehaviour{
    public int LevelToLoad;
    
    public void loadLevel(){
        Scoremanager.LoadScene(LevelToLoad);

    }

    public void LevelExit(){
        Application.Quit();

    }
}




