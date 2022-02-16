using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WinState : MonoBehaviour
{
    public int CurrentKills = 0;
    public int MaxKills = 5;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            CurrentKills++;
        }
    }

    public void update()
    {
        if (CurrentKills == MaxKills)
        {
            SceneManager.LoadScene("Game Won");
        }
    }
}
