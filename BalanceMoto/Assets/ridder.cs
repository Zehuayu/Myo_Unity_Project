using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ridder : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerEnter2D(Collider2D collsion)//OnCollisionEnter2D(Collision2D collision)
	{
		if (collsion.gameObject.tag == "background")
		{
		
			//game over
			ThalmicHub hub = ThalmicHub.instance;
			Destroy(hub);
			Application.LoadLevel (Application.loadedLevel);
			//wSceneManager.LoadScene(0);
		}
	}
}
