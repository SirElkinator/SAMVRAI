using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class Trapdoorenemy : MonoBehaviour {
    int count = 0;
    private bool moveup;
    public AudioSource audioData;
    public GameObject shuriken;
    public Animator anim;
    float spawnDistance = 5;
    
    int throwcount = 0;
    bool throwstar=false;
    // Use this for initialization
    void Start () {
        transform.position = new Vector3(392.3f, -14, 561.7f);
	}

    // Update is called once per frame
    void Update() {
        /* if (count <= 350) {
             transform.Translate(Vector3.up * 2 * Time.deltaTime);
             count = count + 1;
         }
         else if (count >= 700)
         {
             count = 0;
         }
         else if (count >=350)
         {
             transform.Translate(Vector3.down * 2 * Time.deltaTime);
             count = count + 1;
         }*/
        if (moveup == true) {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y + 7, transform.position.z), 3 * Time.deltaTime);
        } else {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y - 7, transform.position.z), 3 * Time.deltaTime);
        }
        if (transform.position.y <= -13) {
            moveup = true;
        }
        if (transform.position.y >= 0) {
            moveup = false;
            
            anim.Play("Default Take");
            throwstar = true;
            

        }
        if (throwstar == true)
        {
            throwcount++;
            if (throwcount >= 70)
            {
                Vector3 playerPos = transform.position;
                Vector3 playerDirection = transform.forward;
                Quaternion playerRotation = transform.rotation;
                Vector3 spawnPos = playerPos + playerDirection * spawnDistance;
                Instantiate(shuriken, spawnPos, transform.rotation);
                audioData = GetComponent<AudioSource>();
                audioData.Play(0);
                throwcount = 0;
                throwstar = false;
            }
        }
    }
   

}
