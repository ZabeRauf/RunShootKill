﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour {

    public GameObject canvas;
    private PlayerTextHandler pth;
    private void Awake()
    {
        pth = gameObject.GetComponent<PlayerTextHandler>();
    }
    // loads up the main game screen.
    //**Right now it only loads a test environment. 
    //  This will be where we call our procedural generation of the level.**
    public void StartGame()
    {
        pth.writePlayer(100f, 0, 0, "pistol", "pistol", "", "", 5);
        SceneManager.LoadScene("HubWorld");
    }

    // Loads the load game screen
    public void LoadMenu()
    {
        SceneManager.LoadScene("HubWorld");
        //SceneManager.LoadScene("LoadMenu");
    }

    // This quits the application.
    public void ExitGame()
    {
        Application.Quit();
    }

    // This returns you to the main menu. 
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

}
