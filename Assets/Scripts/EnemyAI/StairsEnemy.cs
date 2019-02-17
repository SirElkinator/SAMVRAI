using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsEnemy : MonoBehaviour {
    int count = 0;

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(375.77f, 42.61f, 605.53f);
    }

    // Update is called once per frame
    void Update() {
        count = count + 1;
        if (count >= 1200) {
            if (transform.position.y > .61) {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y - 7, transform.position.z), 50 * Time.deltaTime);
            }
        }
        if (transform.position.y <= .61)
        {
            float dist = Vector3.Distance(GameObject.FindWithTag("MainCamera").transform.position, transform.position);

            if (dist > 25)
            {
                var lookPos = GameObject.FindWithTag("MainCamera").transform.position;
                lookPos.y = transform.position.y;
                transform.position = Vector3.MoveTowards(transform.position, lookPos, 1 * Time.deltaTime);
            }
            if (dist < 24)
            {
                var lookPos = GameObject.FindWithTag("MainCamera").transform.position;
                lookPos.y = transform.position.y;
                transform.position = Vector3.MoveTowards(transform.position, lookPos, -2 * Time.deltaTime);
            }
        }
    }
}
