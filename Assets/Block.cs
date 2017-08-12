using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    public float blockSpeed = 15f;
    public Rigidbody rig;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        rig.AddForce(-transform.forward * blockSpeed );
	}

}
