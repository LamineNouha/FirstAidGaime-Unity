using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}

	public void Replay(int level){
		int lives = 3;
		PlayerPrefs.SetInt ("Lives", lives);
		Application.LoadLevel ("Level"+level);
	}

	public void NextLevel(int level, int lives){
		Debug.Log ("ssssssssssss" + (3 - lives));
		PlayerPrefs.SetInt ("Tentatives_perdues", 3-lives);
		PlayerPrefs.SetInt ("Level", level);
		PlayerPrefs.SetInt ("Win",1);
		Application.LoadLevel ("SelectLevel");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartPlay()

	{
		Application.LoadLevel("SelectLevel");


	}


	public void Help()
	{
		Application.LoadLevel("help");

	}


	public void EditParam()
	{
		Application.LoadLevel("settings");

	}


	public void Quit()
	{

		Application.Quit ();
	}


	public void Home()
	{
		Application.LoadLevel("menu");

	}

	public void PlayLevel1()
	{
		Application.LoadLevel ("Level1");
	}
	public void PlayLevel2()
	{
		Application.LoadLevel ("Level2");
	}
	public void PlayLevel3()
	{
		Application.LoadLevel ("Level3");
	}
	public void PlayLevel4()
	{
		Application.LoadLevel ("Level4");
	}

	public void Quizz()
	{
		Application.LoadLevel ("Quizz");
	}



}
