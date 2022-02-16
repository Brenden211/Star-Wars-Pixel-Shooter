using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UI : MonoBehaviour
{
    
    public void PlayGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Controls()
    {
        SceneManager.LoadScene("Controls Page");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
