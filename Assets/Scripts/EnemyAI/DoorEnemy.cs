using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEnemy : MonoBehaviour {
	// Use this for initialization
	void Start () {
        transform.position = new Vector3(418.32f, .61f, 632.51f);
    }
	
	// Update is called once per frame
	void Update () {
        //tranform.translate =
        float dist = Vector3.Distance(GameObject.FindWithTag("MainCamera").transform.position, transform.position);

        if (dist > 25){
            var lookPos = GameObject.FindWithTag("MainCamera").transform.position;
            lookPos.y = transform.position.y;
            transform.position = Vector3.MoveTowards(transform.position, lookPos, 1 * Time.deltaTime);
        }
        if (dist < 24) {
            var lookPos = GameObject.FindWithTag("MainCamera").transform.position;
            lookPos.y = transform.position.y;
            transform.position = Vector3.MoveTowards(transform.position, lookPos, -2 * Time.deltaTime);
        }

    }
}
