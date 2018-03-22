using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {



	public Transform target;
	Vector3 carmera;
	void Start () {
		carmera = target.position;
		carmera.z = -10;

	}
	
	// Update is called once per frame
	void Update () {
		carmera = target.position;
		carmera.z = -10;

		transform.position = carmera;
	}
}
