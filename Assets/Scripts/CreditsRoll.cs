using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsRoll : MonoBehaviour {
    public GameObject creators;
    public GameObject music;
    int count = 0;
    // Use this for initialization
    void Start () {
        creators.SetActive(true);
        music.SetActive(false);
      
	}
	
	// Update is called once per frame
	void Update () {
        count = count + 1;
        if (count > 200)
        {
            creators.SetActive(false);
            music.SetActive(true);
        }
	}
}
