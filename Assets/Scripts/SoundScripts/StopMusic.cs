using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(GameObject))]
public class StopMusic : MonoBehaviour {
    AudioSource audioSource;
    GameObject music;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!audioSource.isPlaying)
        {
            music.SetActive(false);
        }
    }
}
