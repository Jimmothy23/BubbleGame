using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()                      //Function created to load the Counting variation of the bubble pop game
    {
        SceneManager.LoadScene("Counting");

    }

    public void PlayColors()
    {
        SceneManager.LoadScene("Color");       //Function created to load the Colors variation of the bubble pop game
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");        //Function created to load teh menu scene
        ScoreScript.scoreValue = 0;
    }


    public void QuitGame()                    //Function created to quit the game
    {
        Application.Quit();
    }
}
