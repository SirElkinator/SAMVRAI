using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
[RequireComponent(typeof(GameObject))]
public class SwordSpawn : MonoBehaviour
{
    public GameObject katana;
    //public GameObject LeftController;
    //public GameObject RightController;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider otherObj)
    {
        if (otherObj.gameObject.tag == "Head")
        {
            if (GameObject.FindGameObjectsWithTag("Sword").Length < 2) 
            {
                
                Instantiate(katana, transform.position, transform.rotation);
                VRTK_InteractGrab myGrab = katana.GetComponent<VRTK_InteractGrab>();
                myGrab.AttemptGrab();
           //     LeftController.AttemptGrab();
             //   RightController.AttemptGrab();
            }
        }
    }
}