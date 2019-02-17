using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class WindchimeSound : MonoBehaviour
{
    public AudioSource audioData;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter(Collision otherObj)
    {
       
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
        
    }

}
