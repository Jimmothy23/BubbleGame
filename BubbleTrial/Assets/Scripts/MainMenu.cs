﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Counting");

    }

    public void PlayColors()
    {
        SceneManager.LoadScene("Color");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        ScoreScript.scoreValue = 0;
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
