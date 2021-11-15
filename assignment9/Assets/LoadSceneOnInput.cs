using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Submit") == 1) {
			// Proceed from Title to Play Scene
			if (SceneManager.GetActiveScene().name == "Title") {
				SceneManager.LoadScene("Play");
			}
			// Proceed from GameOver to Title Scene
			else {
				SceneManager.LoadScene("Title");
			}
		}
	}
}
