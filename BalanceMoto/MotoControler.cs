using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// purpose is to control two wheels 
	public WheelJoint2D right;
	public WheelJoint2D left;

	[SerializeField]float speed = 1500;


	JointMotor2D motor;

	// Use this for initialization
	void Start () {
		motor.maxMotorTorque = 10000;
		
	}
	
	// Update is called once per frame
	void Update () {
		motor.motorSpeed = - speed * Input.GetAxis ("Vertical");

		right.motor = motor;
		left.motor = motor;

	}
}
