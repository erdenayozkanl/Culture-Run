using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Movement : MonoBehaviour {

    public KeyCode moveL;
    public KeyCode moveR;

    public AudioSource audioSource;
    public AudioClip audioClip;
    public float horizVel=0;
    public int laneNum = 2;
    public string controlLocked = "n";
	// Use this for initialization
	void Start () {
        audioSource.clip = audioClip;
    }

    // Update is called once per frameü

    void Update () {
        
        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, GM.vertVel, 6);
        
        if (Input.GetKeyDown(moveL) && (laneNum > 1) && controlLocked == "n")
        {
            
            horizVel = -2;
            StartCoroutine(stopSlide());
            laneNum -= 1;
            controlLocked = "y";
        }

        if (Input.GetKeyDown(moveR)&& (laneNum < 3) && controlLocked == "n")
        {
           
            horizVel = 2;
            StartCoroutine(stopSlide());
            laneNum += 1;
            controlLocked = "y";
        }


    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="lethal")
        {
            //Time.timeScale = 0f;
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
            MainManu.count = 0;
            //GM.isAlive = false;
            //Debug.Log(GM.healt);

        }
        if (other.gameObject.name == "Capsule")
        {
            Destroy(other.gameObject);
            GM.collect += 1;
            Debug.Log(GM.collect);
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.name == "rampbottomtrig")
        //{
        //    GetComponent<Rigidbody>().velocity = new Vector3(horizVel, GM.vertVel, 4);
        //    GM.vertVel = 2;
        //}
        //if (other.gameObject.name == "ramptoptrig")
        //{
        //    GetComponent<Rigidbody>().velocity = new Vector3(horizVel, GM.vertVel, 4);
        //    GM.vertVel = 0;
        //}
        //if (other.gameObject.tag=="capsule")
        //{
        //    //audio.p
        //    //Audio.PlayOneShot(impact);
        //}
        if (other.gameObject.name == "finish")
        {
            SceneManager.LoadScene("FinalTable");
            Debug.Log("burda");
          
        }
        if (other.gameObject.name == "finish" && MainManu.count==1)
        {
           
            SceneManager.LoadScene("FinalTable1");
            Debug.Log(MainManu.count);

        }

        if (other.gameObject.name == "finish" && MainManu.count == 2)
        {
            
            SceneManager.LoadScene("FinalTable2");
            Debug.Log(MainManu.count);

        }
        if (other.gameObject.tag=="capsule")
        {
            Destroy(other.gameObject);
            audioSource.Play();
            GM.collect += 1;
            Debug.Log(GM.collect);
        }
        //if (other.gameObject.name == "block")
        //{
        //    SceneManager.LoadScene("FinalTable");
        //    Debug.Log("asd");
        //}
    }
    
    
    
    
    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(.5f);
        horizVel = 0;
        controlLocked = "n";
    }
}
