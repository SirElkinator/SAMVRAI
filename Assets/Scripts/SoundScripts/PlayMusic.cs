using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(GameObject))]
public class PlayMusic : MonoBehaviour {
    public GameObject gameObjectToEnable;
    public GameObject Music2;
    public GameObject Music3;
    public GameObject Music4;
    private int choice;
    // Use this for initialization
    void Start () {

        //This script picks a random song from our playlist
        choice = Random.Range(0, 4);
        if (choice == 0)
        {
            gameObjectToEnable.SetActive(true);
        }
        else if (choice == 1)
        {
            Music3.SetActive(true);
        }
        else if (choice == 2)
        {
            Music4.SetActive(true);
        }
        else
        {
            Music2.SetActive(true);
        }
    
}

// Update is called once per frame
void Update() {
        //here should be where a new song starts i believe
}
}
