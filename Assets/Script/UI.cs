using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UI : MonoBehaviour
{ 
    void PlayGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    void Controls()
    {
        SceneManager.LoadScene("Controls Page");
    }

    void Quit()
    {
        Application.Quit();
    }
}
