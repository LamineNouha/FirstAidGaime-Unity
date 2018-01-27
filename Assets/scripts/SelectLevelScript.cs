using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class SelectLevelScript : MonoBehaviour {
	private int MaxLevels=15;
	public static int _UnlockedLevels=1;

	public static int[] StarsMap = new int[15];



	
	//private Text _Tentatives_perduesTextComponent;
	//private Text _WinTextComponent;
	//private Text _LevelTextComponent;
	private int _Tentatives_perdues;
	private int _Win;
	private int _Level;

	private Button _ButtonUnlockedComponent;
	private Button _ButtonToUnlockComponent;

	private Image _ImageS1Component;
	private Image _ImageS2Component;
	private Image _ImageS3Component;

	private GameObject g;
	private GameObject g1;
	private GameObject g2;
	private GameObject g3;



	void Start () {



		PlayerPrefs.SetInt ("Lives", 3);
		//sauvegarder pour la premiere fois _UnlockedLevels 


		int[] StarsMapsaved = SaveLoadManager.Load ();
		Debug.Log ("persistttttttttt" + StarsMapsaved [0]);
		if (StarsMapsaved != null)
       {	//utiliser StarsMap sauvegardée dans le fichier de persistence
			StarsMap = SaveLoadManager.Load ();
			Debug.Log ("persistttttttttt" + StarsMap [0]);
			_UnlockedLevels = StarsMap [0];
		}
			

		//recupération de data
		
		_Tentatives_perdues = PlayerPrefs.GetInt ("Tentatives_perdues");
		_Win = PlayerPrefs.GetInt ("Win");
		_Level = PlayerPrefs.GetInt ("Level");

		Debug.Log("this is Select levels"); 
		Debug.Log("level comming from : "+ _Level); 
		Debug.Log("winning : "+ _Win); 
		Debug.Log("tentatives perdues : "+ _Tentatives_perdues); 
			
		//dernier level to unlock partant de level 2
		//si suite à une scene de jeu et non pas du menu//test si on va unlock ou nn
			if (_Win == 1 && _UnlockedLevels == _Level) {
				_UnlockedLevels = _Level + 1;

				//sauvegarde du nbr de stars du niveau _Level dans le hashmap s'il s'agit d'une amélioration (le nbr de tentatives perdues a diminué) 
				
			}

		if ((3 - _Tentatives_perdues) > StarsMap [_Level])
			StarsMap [_Level] = 3 - _Tentatives_perdues;

		//tjr sauvegarder dans le fichier de persistence après modification de l'etat du jeu
		StarsMap [0] = _UnlockedLevels;
		SaveLoadManager.SavePlayer ();

		//affichage se fait dans tous les cas sauf si le joueur n'a pas réussit le niveau1 ou il n'a pas encore joué (1ere fois)
		if(_UnlockedLevels >1){

			for (int j = 2; j <= _UnlockedLevels; j++) {
				int k = j - 1;
				_ButtonUnlockedComponent = GameObject.Find ("Level" + k).GetComponent<Button> ();//je vais faire apparitre ses stars
				if (GameObject.Find ("LockedLevel" + j)) {
					_ButtonToUnlockComponent = GameObject.Find ("LockedLevel" + j).GetComponent<Button> ();}//je vais la faire disparaitre
		
				GameObject.Find ("LockedLevel" + j).SetActive (false);//je désactive le locked button


		
				int stars;

				stars = (int)StarsMap [k];

				Debug.Log ("effffffffffffffffffffffffffff" + stars);

				g = GameObject.Find ("Level" + k).gameObject;

				if (g != null) {
					if (stars == 1) {

						g1 = g.transform.Find ("Paneld/s1").gameObject;
						g1.GetComponent <CanvasGroup> ().alpha = 0;
					}

					if (stars == 2) {

						g1 = g.transform.Find ("Paneld/s1").gameObject;
						g1.GetComponent <CanvasGroup> ().alpha = 0;
						g2 = g.transform.Find ("Paneld/s2").gameObject;
						g2.GetComponent <CanvasGroup> ().alpha = 0;
					}
					if (stars == 3) {
						
						g1 = g.transform.Find ("Paneld/s1").gameObject;
						g1.GetComponent <CanvasGroup> ().alpha = 0;
						g2 = g.transform.Find ("Paneld/s2").gameObject;
						g2.GetComponent <CanvasGroup> ().alpha = 0;
						g3 = g.transform.Find ("Paneld/s3").gameObject;
						g3.GetComponent <CanvasGroup> ().alpha = 0;
					}
				}
		
					
			}
					
		}
		Debug.Log ("persistttttttttt" + StarsMapsaved [0]);
	}
	

	// Update is called once per frame
	void Update () {SaveLoadManager.SavePlayer ();
		/*_Tentatives_perduesTextComponent.text = _Tentatives_perdues.ToString();
		_WinTextComponent.text = _Win.ToString();
		_LevelTextComponent.text = _Level.ToString();*/


	}



}