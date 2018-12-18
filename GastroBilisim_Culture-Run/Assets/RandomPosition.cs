using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour {

    public GameObject capsule;
    public int capsuleCount;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < capsuleCount; i++)
        {
            Instantiate(capsule, new Vector3(Random.Range(1, 4), 1.5f, Random.Range(5, 50)), Quaternion.identity);
        }
	}
}
