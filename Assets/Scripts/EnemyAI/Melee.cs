using UnityEngine;
using System.Collections;

public class Melee : MonoBehaviour {

    public Rigidbody rb;
    public float speed;

    private Transform swordTransform;
    private bool closerange = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float dist = Vector3.Distance(GameObject.FindWithTag("Player").transform.position, transform.position);

        if (dist > 2.3)
        {
            closerange = false;
        }
        if (dist < 2.5)
        {
            closerange = true;
        }
        if (closerange == false)
        {
            rb.position = Vector3.MoveTowards(transform.position, GameObject.FindWithTag("Player").transform.position, speed * Time.deltaTime);
        }
        else
        {
            Attack();
        }
	}

    void Attack()
    {
        swordTransform = transform.Find("Sword Hilt");
        swordTransform.transform.localRotation = Quaternion.Lerp(swordTransform.localRotation, Quaternion.Euler(new Vector3(90, 0, 30)), 0.01f);
        swordTransform.transform.localRotation = Quaternion.Lerp(swordTransform.localRotation, Quaternion.Euler(new Vector3(15, -180, 30)), 0.01f);
    }
}
