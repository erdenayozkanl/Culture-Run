using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MController : MonoBehaviour {

    public Text score,healt;

    void Start()
    {
        if (GM.healt <= 0)
        {
            healt.text = "Game Over!";
            MainManu.count = 0;
            GM.collect = 0;
        }
    }

    void Update()
    {
        score.text = "Score: " + GM.collect.ToString();
    }

    void GameOver()
    {
        if (GM.healt <= 0)
        {
            score.text = "0";
        }
        
    }


}
