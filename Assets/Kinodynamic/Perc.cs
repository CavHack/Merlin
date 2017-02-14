using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Perc : MonoBehaviour {

	/*

	We cast a ray in front of the agent; when the ray collides with a wall, 
the target object is placed in a new position 
taking into consideration its distance from the wall 
and the safety distance declared and delegating the steering calculations to the 
Seek behavior; this creates the 
illusion of the agent avoiding the wall.

*/

	public bool acyclicWeight = false;
	public bool acyclicPriority = false;
	public float priorityThreshold = 0.2f;
	public bool acyclicPipeline = false;
	
	//Kinodynamic params
	public float maxSpeed;
	public float maxAccel;
	public float maxRotation; 
	











}
