using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoor : MonoBehaviour {
    private bool isRotatorTrigger = true;

    private bool canRotatePlayer = false;
    private Collider triggeringCollider;

    void Update()
    {
        RotatePlayer();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            triggeringCollider = other;

            if (isRotatorTrigger)
                canRotatePlayer = true;
        }
    }

    protected void RotatePlayer()
    {
        if (canRotatePlayer)
            triggeringCollider.transform.Rotate(Vector3.up, -90.0f * Time.deltaTime);
    }
}
