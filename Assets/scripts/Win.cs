using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour {
	public Image _ImageS1Component;
	public Image _ImageS2Component;
	public Image _ImageS3Component;
	public Image Level1;
	public Image Level2;
	public Image Level3;

	public Image _ImageState1Component;
	public Image _ImageState2Component;
	public Image _ImageState3Component;
	public Image _ImageState4Component;

	private int _Tentatives_perdues;
    private int _Level;

	//int stras;
	int lives;


	// Use this for initialization
	void Start () {
		 Debug.Log ("helo from winnnnnnnnnnnnn");


		_Tentatives_perdues = PlayerPrefs.GetInt ("Tentatives_perdues");
        _Level = PlayerPrefs.GetInt ("Level");

		switch (_Level)
		{
		case 1:
			Level1.GetComponent <CanvasGroup> ().alpha = 1;
			break;
		case 2:
			Level2.GetComponent <CanvasGroup> ().alpha = 1;
			break;
		case 3:
			Level3.GetComponent <CanvasGroup> ().alpha = 1;
			break;
		}

		lives = 3 - _Tentatives_perdues;


		Debug.Log("level comming from : "+ _Level); 

		Debug.Log("tentatives perdues : "+ _Tentatives_perdues); 

		if (lives == 1) {
			_ImageS1Component.GetComponent <CanvasGroup> ().alpha = 1;
			_ImageState1Component.GetComponent <CanvasGroup> ().alpha = 1;
		}
		if (lives == 2) {
			_ImageS1Component.GetComponent <CanvasGroup> ().alpha = 1;
			_ImageS2Component.GetComponent <CanvasGroup> ().alpha = 1;
			_ImageState2Component.GetComponent <CanvasGroup> ().alpha = 1;
		}
		if (lives == 3) {
			_ImageS1Component.GetComponent <CanvasGroup> ().alpha = 1;
			_ImageS2Component.GetComponent <CanvasGroup> ().alpha = 1;
			_ImageS3Component.GetComponent <CanvasGroup> ().alpha = 1;
			_ImageState3Component.GetComponent <CanvasGroup> ().alpha = 1;
		}



		PlayerPrefs.SetInt ("Level", _Level);
		PlayerPrefs.SetInt ("Tentatives_perdues", _Tentatives_perdues);
		PlayerPrefs.SetInt ("Win", 1);


		/////////
		Debug.Log("hhhhhhhhhhh herrrrrrrrrrrreeeee level"+PlayerPrefs.GetInt ("Level"));


	}

	public void Replay(){
		int lives = 3;
		PlayerPrefs.SetInt ("Lives", lives);
		Application.LoadLevel ("Level"+_Level);
	}

	public void NextLevel(){
		Debug.Log ("ssssssssssss" + (3 - lives));
		PlayerPrefs.SetInt ("Tentatives_perdues", _Tentatives_perdues);
		PlayerPrefs.SetInt ("Level", _Level);
		PlayerPrefs.SetInt ("Win",1);
		Application.LoadLevel ("SelectLevel");
	}


	public void Home(){
		
		Application.LoadLevel ("menu");
	}

	
	// Update is called once per frame
	void Update () {
		/* PlayerPrefs.SetInt ("Tentatives_perdues", _Tentatives_perdues);
		PlayerPrefs.SetInt ("Level", _Level);
		PlayerPrefs.SetInt ("Win",1);*/
	}
}
