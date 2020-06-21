using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuConroller : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;
    //this button starts the game
    public void playGame()
    {
        SceneManager.LoadScene("Bar");
    }

    //this button can either show you how to play or something else
    public void options()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    //this button goes back to main menu
    public void back()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }

    //this button exits the game
    public void exitGame()
    {
        Application.Quit();
    }
}
