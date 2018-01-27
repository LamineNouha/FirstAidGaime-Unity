using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class ManagerLevel3 : MonoBehaviour {
    public  Text aff;
    public string nextlevel, stars;
	public string EFtr1, GStr1, EFtr2, GStr2, GScover;
   
	public  Text liveText;
	public  Text liveText2;
	//  Text t;
   // public Image window;
   // public Image fire1, fire2, fire3, fire4, fire5, fire6, fire7, fire8, fire9, fire10, fire11;
   public  int test ;
    public bool phone ;
	public bool wind ,wat;
	public bool oktr1,oktr2, okcover;
    public Image women,water,phon,women2;
	public Image victim, cover,victim2, cover2;
    public int i = 0,tester=0;
    public GameObject ob;
	public GameObject placehold1;
	public GameObject placehold2;
	float Distance1;
	float Distance2;
	public Button bl;
	public static int lives;


	/// <summary>
	/// /////////////
	/// </summary>
	public Image back2;
	public Image panelphone;
	public Text t;
	public Text aff2;
	int _Level;
	int _win;
	public GameObject Panel;
    // Use this for initialization

    void Start () {
		lives = PlayerPrefs.GetInt("Lives");
		_Level = 3;
		_win = 0;
		//back2=GameObject.Find ("Background2").GetComponent<Image> ();
		
		//liveText = GameObject.Find ("TextL").GetComponent<Text> ();
		//liveText = GameObject.Find ("TextL2").GetComponent<Text> ();

		liveText.text = lives.ToString ();
		liveText2.text = lives.ToString ();

		EFtr1 = "empty";
		GStr1 = "go";
		EFtr2 = "empty";
		GStr2 = "go";
		GScover = "go";
        wind = true;
        phone = false;
        wat = false;
		okcover = false;
		oktr1 = false;oktr2 = false;
        test = 1;
        aff = GameObject.Find("Text").GetComponent<Text>();
        lives = 3;
		if (tester == 1) {
			aff.text = "\n" +
				"Ok good!" +
				"\n" +
				"now cover the victim!";
			placehold1 = GameObject.Find ("pel1");
			placehold2 = GameObject.Find ("pel2");
			GameObject.Find ("tr1").transform.position = placehold1.transform.position;
			GameObject.Find ("tr2").transform.position = placehold2.transform.position;
			phon.enabled = false;


		}

    }
	public void Help()
	{
		Panel.SetActive (true);
	}
	public void exitHelp()
	{
		Panel.SetActive (false);
	}

	void update()
	{
		liveText.text = lives.ToString ();
		liveText2.text = lives.ToString ();
		if (tester == 1) {

			placehold1 = GameObject.Find ("pel1");
			placehold2 = GameObject.Find ("pel2");
			GameObject.Find ("tr1").transform.position = placehold1.transform.position;
			GameObject.Find ("tr2").transform.position = placehold2.transform.position;
			phon.GetComponent<CanvasGroup>().alpha = 0;

		}

	}


	public void Dragtr1 (){
		//store position of mouse
		if (GStr1.Equals ("go")) {
			GameObject.Find ("tr1").transform.position = Input.mousePosition;

			aff.text = "\n" +
				"As you do that, make sure that you are 100 meters far away from the accident!";
		}
	}

	public void Droptr1 (){
		float min;
		
		placehold1 = GameObject.Find ("pel1");
		Distance1 = Vector2.Distance (GameObject.Find ("tr1").transform.position, placehold1.transform.position);
		placehold2 = GameObject.Find ("pel2");
		Distance2 = Vector2.Distance (GameObject.Find ("tr1").transform.position, placehold2.transform.position);

		if (Distance1 < Distance2) {


			if (Distance1 < 50) {
				//	print ("In if statement!");
				if (EFtr1.Equals ("empty")) {
					GameObject.Find ("tr1").transform.position = placehold1.transform.position;
					EFtr1 = "full";
					GStr1 = "stop";
					oktr1 = true;
				}
			}
		} else {
			if (Distance2 < 50) {
				//	print ("In if statement!");
				if (EFtr2.Equals ("empty")) {
					GameObject.Find ("tr1").transform.position = placehold2.transform.position;
					EFtr2 = "full";
					GStr1 = "stop";
					oktr1 = true;
				}
			}

		}
		if(GStr1.Equals("stop")&&GStr2.Equals("stop"))
		{
			women.sprite = Resources.Load<Sprite>("women/face1t1") as Sprite;
			aff.text = "\n" +
				"Good job!" +
				"\n" +
				"now let's call for help!";
		}
	}

	public void Dragtr2 (){
		//store position of mouse
		if (GStr2.Equals ("go")) {
			GameObject.Find ("tr2").transform.position = Input.mousePosition;

			aff.text = "\n" +
				"Always be carefull!";
		}
	}

	public void Droptr2 (){
		float min;

		placehold1 = GameObject.Find ("pel1");
		Distance1 = Vector2.Distance (GameObject.Find ("tr2").transform.position, placehold1.transform.position);
		placehold2 = GameObject.Find ("pel2");
		Distance2 = Vector2.Distance (GameObject.Find ("tr2").transform.position, placehold2.transform.position);

		if (Distance1 < Distance2) {

			if (Distance1 < 50) {
				//	print ("In if statement!");
				if (EFtr1.Equals ("empty")) {
					GameObject.Find ("tr2").transform.position = placehold1.transform.position;
					EFtr1 = "full";
					GStr2 = "stop";
					oktr2 = true;
				}
			}
		} else {
			if (Distance2 < 50) {
				//	print ("In if statement!");
				if (EFtr2.Equals ("empty")) {
					GameObject.Find ("tr2").transform.position = placehold2.transform.position;
					EFtr2 = "full";
					GStr2 = "stop";
					oktr2 = true;

				}
			}

		}
		if(GStr1.Equals("stop")&&GStr2.Equals("stop"))
		{
			women.sprite = Resources.Load<Sprite>("women/face1t1") as Sprite;
			aff.text = "\n" +
				"Good job!" +
				"\n" +
				"now let's call for help!";
		}
	}
	public void OnPhone()
	{
		if(tester==1)
		{
			aff.text = "\n" +
				"NO!" +
				"\n" +
				"You already called for help!";
			print ("lives=" + lives.ToString ());
			if (lives > 0) {
				lives--;
				liveText.text = lives.ToString ();
				liveText2.text = lives.ToString ();
			} else {
				aff.text = "\n" +
					"Game OVER!!!";
				PlayerPrefs.SetInt ("Level", _Level);
				Application.LoadLevel("GameOver");
			}
		
		}
		if (!oktr1 && !oktr2) {
			
		
			aff.text = "\n" +
			"NO!" +
			"\n" +
			"You have to protect the scene first!";
			if (lives > 0) {
				lives--;
				liveText.text = lives.ToString ();
				liveText2.text = lives.ToString ();
			} else {
				aff.text = "\n" +
					"Game OVER!!!";
				PlayerPrefs.SetInt ("Level", _Level);
				Application.LoadLevel("GameOver");
			}
		} else {women2.sprite = Resources.Load<Sprite>("women/face1t1") as Sprite;
			back2.gameObject.SetActive (true);
			tester = 0;
			//t= GameObject.Find("Text2").GetComponent<Text>(); 
			liveText2.text = lives.ToString ();
			aff2.text = "\n" +
				"Good!" +
				"\n" +
				"Now type in the emergency number!";
		   phone = true;
			//Application.LoadLevel("scene3");
		}

	}

	public void onClick(int i)
	{
		t.text = t.text + i.ToString();

	}
	public void test1()
	{
		print("call");
		if (t.text.Equals("190"))
		{	tester = 1;
			aff2.text = "Very good.";
			women2.sprite = Resources.Load<Sprite>("women/face3t") as Sprite;
			panelphone.gameObject.SetActive (false);
		if (tester == 1) {
			aff2.text = "\n" +
				"Ok good!" +
				"\n" +
				"now cover the victim!";
			//placehold1 = GameObject.Find ("pel1");
			//placehold2 = GameObject.Find ("pel2");
			//GameObject.Find ("tr1").transform.position = placehold1.transform.position;
			//GameObject.Find ("tr2").transform.position = placehold2.transform.position;
			phon.enabled = false;
				/*EFtr1 = "empty";
				GStr1 = "go";
				EFtr2 = "empty";
				GStr2 = "go";*/
				GScover = "go";
				/*wind = true;
				phone = false;
				wat = false;
				okcover = false;*/


		}

			//Application.LoadLevel("scene1");

		}
		else
		{
			aff2.text = "Try again!";
			if (lives > 0) {
				lives--;
				liveText2.text = lives.ToString ();
			} else {
				aff2.text = "\n" +
					"Game OVER!!!";
				PlayerPrefs.SetInt ("Level", _Level);
				Application.LoadLevel("GameOver");
			}

			women2.sprite = Resources.Load<Sprite>("women/face7t") as Sprite;
			t.text = "";
		}
	}

	public void DragCover (){
		
		//store position of mouse
		if (GScover.Equals ("go")) {
			if (tester == 0) {
				if (!oktr1) {
					
					aff2.text = "\n" +
					"No!" +
					"Secure the scene first!";
					
				}

				if (!phone) {
					
					aff2.text = "\n" +
						"No!" +
						"Call for help!";
				
				}
			} else {
				

				GameObject.Find ("cover2").transform.position = Input.mousePosition;
				aff2.text = "\n" +
				"Keep talking to the victim!";
				
				
			}
		}
	}


	public void DropCover (){
		
		placehold1 = GameObject.Find ("pelc2");
		Distance1 = Vector2.Distance (GameObject.Find ("cover2").transform.position, placehold1.transform.position);

			if (Distance1 < 50) {
				GameObject.Find ("cover2").transform.position = placehold1.transform.position;

			victim2.sprite = Resources.Load<Sprite>("victime/tac2") as Sprite;

		
			cover.enabled = false;
					GScover = "stop";
		
					okcover = true;


			}


		if (okcover) {
			

			aff2.text = "\n" +
				"Great job!" +
				"\n" +
				"Stay there and wait for the help to come";


			_win = 1;
			PlayerPrefs.SetInt ("Level", 3);
			PlayerPrefs.SetInt ("Tentatives_perdues", 3 - lives);
			PlayerPrefs.SetInt ("Win", _win);

			Debug.Log("your are wining from level: "+ _Level); 


			int a = 3 - lives;
			Debug.Log("tentatives perdues : "+ a); 
			StartCoroutine ("wait");


		}
	}
	public IEnumerator wait()
	{yield return new WaitForSeconds (2);
		Application.LoadLevel ("Win");
	}

	public void OnCover2()
	{

		if (!oktr1 && !oktr2 && !phone) {

			aff2.text = "\n" +
			"NO!" +
			"\n" +
			"You have to protect the scene and " +
			"\n" +
			"call for help first! ";
			if (lives > 0) {
				lives--;
				liveText.text = lives.ToString ();
				liveText2.text = lives.ToString ();
			} else {
				aff2.text = "\n" +
				"Game OVER!!!";
				PlayerPrefs.SetInt ("Level", _Level);
				Application.LoadLevel ("GameOver");
			}
		
		} else {
			if (!phone) {
				
				aff2.text = "\n" +
				"NO!" +
				"\n" +
				"You have call for help first! ";
				if (lives > 0) {
					lives--;
					liveText.text = lives.ToString ();
					liveText2.text = lives.ToString ();
				} else {
					aff.text = "\n" +
					"Game OVER!!!";
					PlayerPrefs.SetInt ("Level", _Level);
					Application.LoadLevel ("GameOver");
				}
			} else {
				women.sprite = Resources.Load<Sprite> ("women/face1t1") as Sprite;
				aff2.text = "\n" +
				"Good!" +
				"\n" +
				"Now cover the victim!";
				phone = true;
			}
		}
	}
		public void OnCover1()
	{

		if (!oktr1 && !oktr2 && !phone) {

			aff.text = "\n" +
			"NO!" +
			"\n" +
			"You have to protect the scene and " +
			"\n" +
			"call for help first! ";
			if (lives > 0) {
				lives--;
				liveText.text = lives.ToString ();
				liveText2.text = lives.ToString ();
			} else {
				aff.text = "\n" +
				"Game OVER!!!";
				PlayerPrefs.SetInt ("Level", _Level);
				Application.LoadLevel ("GameOver");
			}

		} else {
			if (!phone) {

				aff.text = "\n" +
				"NO!" +
				"\n" +
				"You have call for help first! ";
				if (lives > 0) {
					lives--;
					liveText.text = lives.ToString ();
					liveText2.text = lives.ToString ();
				} else {
					aff.text = "\n" +
					"Game OVER!!!";
					PlayerPrefs.SetInt ("Level", _Level);
					Application.LoadLevel ("GameOver");
				}
			} else {
				women.sprite = Resources.Load<Sprite> ("women/face1t1") as Sprite;
				aff.text = "\n" +
				"Good!" +
				"\n" +
				"Now cover the victim!";
				phone = true;
			}
		}
	}


	

}