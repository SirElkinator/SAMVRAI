using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
//[RequireComponent(typeof(Animator))]
public class Throw : MonoBehaviour {

    public GameObject knife;
    public GameObject shuriken;
    public AudioSource audioData;
    private bool isWaiting = false;
    private int choice;
    public Animator anim;
    float spawnDistance = 5;
    bool throwstar = false;
    int throwcount = 0;
 //   public Animator anim;


    void Start() {
       // transform.LookAt(GameObject.FindWithTag("MainCamera").transform);
    }

    void Update(){

        if (throwstar == true)
        {
            throwcount++;
            if (throwcount >= 65)
            {
                Vector3 playerPos = transform.position;
                Vector3 playerDirection = transform.forward;
                Quaternion playerRotation = transform.rotation;
                Vector3 spawnPos = playerPos + playerDirection * spawnDistance;
                Instantiate(knife, spawnPos, transform.rotation);
                audioData = GetComponent<AudioSource>();
                audioData.Play(0);
                throwcount = 0;
                throwstar = false;
            }
        }

        if (isWaiting == false) {
            isWaiting = true;
            StartCoroutine(Timer());
        }
    }

    IEnumerator Timer()
    {

       // Vector3 playerPos = transform.position;
       // Vector3 playerDirection = transform.forward;
       // Quaternion playerRotation = transform.rotation;
  
        //Vector3 spawnPos = playerPos + playerDirection * spawnDistance;
        
        yield return new WaitForSeconds(5);
        //Instantiate(knife, transform.position, Quaternion.LookRotation(new Vector3(0,0,0)));
        choice = Random.Range(0, 2);
        /* if (choice == 0)
         {
             Instantiate(knife, transform.position, transform.rotation);
         }
         else
         {*/
        //Instantiate(shuriken);


        anim.Play("Default Take");
        throwstar = true;
       
        // }
        isWaiting = false;
        
    }
    }

