using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createRigid : MonoBehaviour {

    public Transform spawnPoint;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = gameObject.AddComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < spawnPoint.position.y - 10)
        {
            transform.position = spawnPoint.position;
            rb.velocity = Vector3.zero;
        }
	}
}
