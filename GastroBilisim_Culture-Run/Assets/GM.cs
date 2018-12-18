using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour {


    public static float vertVel = 0;
    public static int collect = 0;
    public static float time = 0;
    public static int healt = 1;
    //public static string status="";
    //public float waittoload = 0;
    //public static bool isAlive;
	// Use this for initialization
	void Start () {
        ////isAlive = true;
	}
	
	// Update is called once per frame
	void Update () {
        //if (!isAlive)
        //{
        //    time += Time.deltaTime;
        //    if(time > 2)
        //    {
        //        EndGame();
        //    }
        //}

	}

    void EndGame()
    {
        MainManu.count = 0;
        SceneManager.LoadScene("FinalTable");
        GM.collect = 0;
        
    }
}
