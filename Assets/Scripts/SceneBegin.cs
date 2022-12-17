using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBegin : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene("Menu");
    }
    
    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }
}
