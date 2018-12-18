using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManu : MonoBehaviour {
    public static int count=0;
    public void PlayGame()
    {

        SceneManager.LoadScene("Level1");

    }
   // public void IntroGame()
    //{
    //    SceneManager.LoadScene("Level1");
   // }

    public void NextLevel()
    {
        count++;
        SceneManager.LoadScene("Level2");
        GM.collect = 0;
        
    }
    public void NextLevel1()
    {
        count++;
        SceneManager.LoadScene("Level3");
        GM.collect = 0;

    }
    public void QuitGame()
    {
        count = 0;
        SceneManager.LoadScene("StartSceen");
    }
    public void QuitGame1()
    {
        
        Application.Quit();
        
    }
}
