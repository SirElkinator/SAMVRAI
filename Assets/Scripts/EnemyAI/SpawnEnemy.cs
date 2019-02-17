using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {
    public static int killcount = 0;

    public GameObject DoorEnemy;
    public GameObject StairsEnemy;
    public GameObject TrapdoorEnemy;
    int count = 0;
    int doorenemycount = 0;
    int stairsenemycount = 0;
    int trapdoorenemycount = 0;
    int random = 0;
	// Use this for initialization
	void Start () {
        killcount = 0;
	}
	
	// Update is called once per frame
	void Update () {
        count = GameObject.FindGameObjectsWithTag("Enemy").Length;
        doorenemycount = GameObject.FindGameObjectsWithTag("DoorEnemy").Length;
        stairsenemycount = GameObject.FindGameObjectsWithTag("StairsEnemy").Length;
        trapdoorenemycount = GameObject.FindGameObjectsWithTag("TrapdoorEnemy").Length;
        while (count < 2)
        {
            random = Random.Range(0,3);
           
            if ((random == 0) && (doorenemycount == 0))
            {
                Instantiate(DoorEnemy, transform.position, transform.rotation);
                count++;
                doorenemycount++;
            }
            if ((random == 1) && (stairsenemycount==0))
            {
                Instantiate(StairsEnemy, transform.position, transform.rotation);
                count++;
                stairsenemycount++;
            }
            if ((random == 2) && (trapdoorenemycount==0))
            {
                Instantiate(TrapdoorEnemy, transform.position, transform.rotation);
                count++;
                trapdoorenemycount++;
            }
        }
    }
}
