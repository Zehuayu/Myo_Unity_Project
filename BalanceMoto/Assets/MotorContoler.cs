using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LockingPolicy = Thalmic.Myo.LockingPolicy;
using Pose = Thalmic.Myo.Pose;
using UnlockType = Thalmic.Myo.UnlockType;
using VibrationType = Thalmic.Myo.VibrationType;

public class MotorContoler : MonoBehaviour {


	// purpose is to control two wheels 
	public WheelJoint2D right;
	public WheelJoint2D left;

	[SerializeField]float speed = 1500;
	[SerializeField]float rotation = 1500;

	Rigidbody2D rg;


	JointMotor2D motor;

	public GameObject myo = null;
	private Quaternion _antiYaw = Quaternion.identity;
	private Pose _lastPose = Pose.Unknown;



	// Use this for initialization
	void Start () {
		motor.maxMotorTorque = 10000;
		rg = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update () {
		ThalmicMyo thalmicMyo = myo.GetComponent<ThalmicMyo> ();




		if (thalmicMyo.pose != _lastPose) {
			_lastPose = thalmicMyo.pose;


			if (thalmicMyo.pose == Pose.WaveIn) {

				motor.motorSpeed = motor.motorSpeed + 500;
				right.motor = motor;

				ExtendUnlockAndNotifyUserAction (thalmicMyo);
			} else if (thalmicMyo.pose == Pose.WaveOut) {
				motor.motorSpeed = motor.motorSpeed - 500;
				left.motor = motor;
				ExtendUnlockAndNotifyUserAction (thalmicMyo);
			} else if (thalmicMyo.pose == Pose.Fist) {
		

				rg.AddTorque (-rotation * 10 * Time.deltaTime);

				ExtendUnlockAndNotifyUserAction (thalmicMyo);
			} else if (thalmicMyo.pose == Pose.FingersSpread)
			{


				rg.AddTorque (rotation * 10 * Time.deltaTime);

				ExtendUnlockAndNotifyUserAction (thalmicMyo);

			} 
			else if (thalmicMyo.pose == Pose.DoubleTap) {
			
				ThalmicHub hub = ThalmicHub.instance;
				Destroy(hub);
				Application.LoadLevel (Application.loadedLevel);
			}
		
		}	

	}


	  void ExtendUnlockAndNotifyUserAction (ThalmicMyo myo)
	{
		ThalmicHub hub = ThalmicHub.instance;

		if (hub.lockingPolicy == LockingPolicy.Standard) {
			myo.Unlock (UnlockType.Timed);
		}

		myo.NotifyUserAction ();
	}
}
