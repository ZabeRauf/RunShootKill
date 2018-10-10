﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour {

	public void LoadGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void LoadLoadMenu()
    {
        SceneManager.LoadScene("LoadMenu");
    }
}