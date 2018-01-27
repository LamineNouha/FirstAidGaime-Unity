using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour {
	/*private int _Tentatives_perdues;
	private int _Win;
	private int _Level;
*/
	// Use this for initialization
	void Start () {


		//debut sauvegarde persistence//

		//sauvegarde en cas de win et ne passe pas par le select level, il a choisi de retourner au menu
		//recupération de data

		int _Tentatives_perdues = PlayerPrefs.GetInt ("Tentatives_perdues");
		int _Win = PlayerPrefs.GetInt ("Win");
		int _Level = PlayerPrefs.GetInt ("Level");


		//dernier level to unlock partant de level 2
		//si suite à une scene de jeu et non pas du menu//test si on va unlock ou nn
		if (_Win == 1 && SelectLevelScript._UnlockedLevels == _Level) {
			SelectLevelScript._UnlockedLevels = _Level + 1;

			//sauvegarde du nbr de stars du niveau _Level dans le hashmap s'il s'agit d'une amélioration (le nbr de tentatives perdues a diminué) 

		}

		if ((3 - _Tentatives_perdues) > SelectLevelScript.StarsMap [_Level])
			SelectLevelScript.StarsMap [_Level] = 3 - _Tentatives_perdues;

		//tjr sauvegarder dans le fichier de persistence après modification de l'etat du jeu
		SelectLevelScript.StarsMap [0] = SelectLevelScript._UnlockedLevels;
		SaveLoadManager.SavePlayer ();

		//fin sauvegarde persistence//

		//en cas du choix "jouer encore" c.a.d start => initialisation

		//pour un passage par le select level sans rien changer dans nos vars staitiques
		PlayerPrefs.SetInt ("Tentatives_perdues",3);
		PlayerPrefs.SetInt ("Level",1); //1 car le min level unlocked est 1 
		PlayerPrefs.SetInt ("Win",0);
		 
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
