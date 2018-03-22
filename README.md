# Myo_Unity_Project
 Myo app with Unity     developer: Zehua YU 
 Student ID: G00307279   Lecturer: Damien

## What is Myo

The Myo armband is a gesture recognition device worn on the forearm and manufactured by Thalmic Labs. The Myo enables the user to control technology wirelessly using various hand motions. It uses a set of electromyographic sensors that sense electrical activity in the forearm muscles, combined with a gyroscope, accelerometer and magnetometer to recognize gestures. The Myo can be used to control video games, presentations, music and visual entertainment. It differs from the Leap Motion device as it is worn rather than a 3D array of cameras that sense motion in the environment.

## What is Unity

Unity is a cross-platform game engine developed by Unity Technologies, which is primarily used to develop both three-dimensional and two-dimensional video games and simulations for computers, consoles, and mobile devices. First announced only for OS X at Apple's Worldwide Developers Conference in 2005, it has since been extended to target 27 platforms. Six major versions of Unity have been released. For a list of games made with Unity, visit List of Unity games.

## What is my game 

Balance Motor, which is kind of game, the player control the wheel going ahead and going back and keeping the balance
which gesture is used
wave out: the motor go ahead
wave in : the motor go back
fist: rotation
FingersSpread: rotation
DoubleTap: restart game

example 
                if (thalmicMyo.pose == Pose.WaveIn) {

				motor.motorSpeed = motor.motorSpeed + 500;
				right.motor = motor;

				ExtendUnlockAndNotifyUserAction (thalmicMyo);
			} else if (thalmicMyo.pose == Pose.WaveOut) {
				motor.motorSpeed = motor.motorSpeed - 500;
				left.motor = motor;
				ExtendUnlockAndNotifyUserAction (thalmicMyo);
			}

## Problem solved

when restart the game, the program needs to close the Myo connection.
               
               
                ThalmicHub hub = ThalmicHub.instance;
				Destroy(hub);
				Application.LoadLevel (Application.loadedLevel);


## Resource from      

https://developer.thalmic.com/start
https://www.bilibili.com/video/av10088732       


