# Myo_Unity_Project
 Myo app with Unity     developer: Zehua YU 
 Student ID: G00307279   Lecturer: Damien
## The Requirement of project

Purpose of the application : design of the application including the screens of the user interface and
how it works. The application can be an experimentation process for you, testing how pieces of
hardware could interact or be combined with gestures. You don’t have to solve the world economic
crisis just yet.

Gestures identified as appropriate for this application : consider how gestures can be incorporated
into the application, making a justified argument for the ones that you pick. This is a research
element for the project.

Hardware used in creating the application : You are not limited to the hardware listed above. If
you have your own hardware, or hardware simulator that you wish to use, then feel free. The
purpose of each piece of hardware should be given with a comparison to other options available.

Architecture for the solution : the full architecture for the solution, including the class diagrams,
any data models, communications and distributed elements that you are creating.

Conclusions & Recommendations : Conclusions are what you have learned from this project and
the associated research. Recommendations are what you would do differently if you were to
undertake the project again. The Reflective Piece – what I learned and “enjoyed” 

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

example（Changing the value to drive the motor by gesture）
                    
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

## class introduction

MotorContoler: this class contains all operational function including the sensoer code
CameraFollow: this is sample class for the monitor following the motor
DeathLine Winline: them are conditional class, when motor got them, one result will be happen

## Gusture

![](https://github.com/Zehuayu/Myo_Unity_Project/blob/master/iamges/111.gif)

## Resource from      
https://developer.thalmic.com/start  
https://www.bilibili.com/video/av10088732       


