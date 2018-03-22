using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Winline : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerEnter2D(Collider2D collsion)
	{
		if (collsion.gameObject.tag == "winline")
		{
			//game over
			ThalmicHub hub = ThalmicHub.instance;
			Destroy(hub);
			Application.LoadLevel (Application.loadedLevel);
		//	SceneManager.LoadScene(0);
		}
	}
}
