using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loose : MonoBehaviour {
	//private int _Tentatives_perdues;
	int _Level;
	// Use this for initialization
	void Start () {
		Debug.Log ("helo from game over");


		int _Tentatives_perdues = PlayerPrefs.GetInt ("Tentatives_perdues");
		int _Level = PlayerPrefs.GetInt ("Level");

		PlayerPrefs.SetInt ("Tentatives_perdues",3);
		PlayerPrefs.SetInt ("Level", _Level);
		PlayerPrefs.SetInt ("Win",0);

	}


	public void Replay(){
		int lives = 3;
		PlayerPrefs.SetInt ("Lives", lives);
		Application.LoadLevel ("Level"+_Level);
	}




	public void Home(){

		Application.LoadLevel ("menu");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
