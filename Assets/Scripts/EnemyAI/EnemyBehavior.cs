using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]

public class EnemyBehavior : MonoBehaviour
{
    public float gravity = 9.81f;
    private Vector3 moveDirection = Vector3.zero;
   // public GameObject otherObject;
    public GameObject Smoke;
    public GameObject sword;
   // public Animator anim;

    // Use this for initialization
    void Start()
    {
       // anim.Play("Standard_Idle");
    }

    // Update is called once per frame
    void Update()
    {
        // anim = GetComponent<Animator>();
        var lookPos = GameObject.FindWithTag("MainCamera").transform.position;
        lookPos.y = transform.position.y;
        transform.LookAt(lookPos);
        //nim.Play("Standard_Idle");
    
    }
   private void OnCollisionEnter(Collision otherObj)
    {
        Debug.Log(otherObj.gameObject);
        if (otherObj.gameObject.tag == "Shuriken"){
            SpawnEnemy.killcount++;
            Instantiate(Smoke,transform.position, new Quaternion(0,0,0,0));
            Destroy(gameObject);
        }
        if (otherObj.gameObject.tag == "Sword") {
            SpawnEnemy.killcount++;
            Instantiate(Smoke, transform.position, new Quaternion(0, 0, 0, 0));
            Destroy(gameObject);
        }
    }
}
