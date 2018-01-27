using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ManagerLevel2 : MonoBehaviour {
    public  Text aff;
    public string nextlevel, stars;
    public  int lives;
    
    public Image window;
    public Image fire1, fire2, fire3, fire4, fire5, fire6, fire7, fire8, fire9, fire10, fire11;
    public  int test ;
    public bool phone ;
    public bool wind ,wat;
    public Image women,water,women2;
    public int i = 0;
    public GameObject ob;

	/// <summary>
	/// /////////////
	/// </summary>
	public Image PopupPhone;
	public Text t;
	public Text aff2;
	int _Level;
	int _win;
	public  Text liveText;
	public  Text liveText2;
	public GameObject Panel;


    // Use this for initialization
    void Start () {
		_Level = 2;
		_win = 0;
        wind = true;
        phone = false;
        wat = false;
        test = 1;

        aff = GameObject.Find("Text").GetComponent<Text>();
        fire1= GameObject.Find("Image/fire1").GetComponent<Image>();
        fire2 = GameObject.Find("Image/fire2").GetComponent<Image>();
        fire3 = GameObject.Find("Image/fire3").GetComponent<Image>();
        fire4 = GameObject.Find("Image/fire4").GetComponent<Image>();
        fire5 = GameObject.Find("Image/fire5").GetComponent<Image>();
        fire6 = GameObject.Find("Image/fire6").GetComponent<Image>();
        fire7 = GameObject.Find("Image/fire7").GetComponent<Image>();
        fire8 = GameObject.Find("Image/fire8").GetComponent<Image>();
        fire9 = GameObject.Find("Image/fire9").GetComponent<Image>();
        fire10 = GameObject.Find("Image/fire10").GetComponent<Image>();
        fire11 = GameObject.Find("Image/fire11").GetComponent<Image>();







		//t= GameObject.Find("numertext").GetComponent<Text>(); 
	//	aff = GameObject.Find("mes").GetComponent<Text>();


        print("hello");
		lives = PlayerPrefs.GetInt("Lives");
		liveText.text = lives.ToString ();
		liveText2.text = lives.ToString ();

       // liveText.text = lives.ToString();


    }

	public void Help()
	{
		Panel.SetActive (true);
	}
	public void exitHelp()
	{
		Panel.SetActive (false);
	}

	/// <summary>
	/// ///////////////deb de fusion
	/// </summary>

	/*public void testphone()
	{
		print("call");
		if (t.text.Equals("197"))
		{
			aff.text = "Very good.";
			women.sprite = Resources.Load<Sprite>("women/face3t") as Sprite;

		}
		else
		{
			aff.text = "Oh No , You are wrong ,try again";
			women.sprite = Resources.Load<Sprite>("women/face7t") as Sprite;

			t.text = "";
			lives--;
		}
	}

	public void onClick(int i)
	{

		t.text = t.text + i.ToString();



	}


	/// <summary>
	/// ///////////////fin de fusion
	/// </summary>*/
	/// 
    public void OnMouseDown()
    {
		


		if (wind && !phone && !wat && test==1)
        {
            window.sprite = Resources.Load<Sprite>("ouv") as Sprite;
            women.sprite = Resources.Load<Sprite>("women/face1t1") as Sprite;

            aff.text = "very good . Nowwe need some water.";
            fire11.GetComponent<CanvasGroup>().alpha = 0;
            fire2.GetComponent<CanvasGroup>().alpha = 0;
            fire10.GetComponent<CanvasGroup>().alpha = 0;
            
            fire7.GetComponent<CanvasGroup>().alpha = 0;

            test = 2;
            wind = false;
            phone = true;
        }
        else if( test==2 )
        {
            lives--;
			liveText.text = lives.ToString ();
			liveText2.text = lives.ToString ();
            aff.text = "Oh no .....water .";
            women.sprite = Resources.Load<Sprite>("women/face7t") as Sprite;


			if (lives == 0) {
				PlayerPrefs.SetInt ("Level", _Level);
				Application.LoadLevel ("Gameover");
			}


        }
        else if (test == 3)
        {
            lives--;
			liveText.text = lives.ToString ();
			liveText2.text = lives.ToString ();
            aff.text = "Oh no .you need to call for help .";
            women.sprite = Resources.Load<Sprite>("women/face7t") as Sprite;


			if (lives == 0) {
				PlayerPrefs.SetInt ("Level", _Level);
				Application.LoadLevel ("Gameover");
			}


        }

    }




	/// <summary>
	/// //////////////////
	/// </summary>
	public void onClick(int i)
	{

		t.text = t.text + i.ToString();



	}



	public void test1()
	{
		print("call");
		if (t.text.Equals("197"))
		{
			aff2.text = "Very good.";
			women2.sprite = Resources.Load<Sprite>("women/face3t") as Sprite;


			_win = 1;
			PlayerPrefs.SetInt ("Level", 2);
			PlayerPrefs.SetInt ("Tentatives_perdues", 3 - lives);
			PlayerPrefs.SetInt ("Win", _win);

			Debug.Log("from level 222222222222 we pass"); 

			Debug.Log("level comming from : "+ _Level); 
			int a = 3 - lives;
			Debug.Log("tentatives perdues : "+ a); 
			Application.LoadLevel ("Win");

		}
		else
		{
			aff2.text = "Oh No , You are wrong ,try again";
			women2.sprite = Resources.Load<Sprite>("women/face7t") as Sprite;

			t.text = "";
			lives--;
			liveText.text = lives.ToString ();
			liveText2.text = lives.ToString ();

			if (lives == 0) {
				PlayerPrefs.SetInt ("Level", _Level);
				Application.LoadLevel ("Gameover");
			}
		}
	}  

	/// <summary>
	/// ///////////////
	/// </summary>

    public void OnMouseDown2()
    {
        print("phone");
        print("wind=" + wind);
        print("phone=" + phone);


       
		if (phone && !wind &&  !wat &&test==3)
		{  PopupPhone.gameObject.SetActive (true);
			
			////////7
			t= GameObject.Find("numertext").GetComponent<Text>(); 
			aff2 = GameObject.Find("mes").GetComponent<Text>();




            //window.sprite = Resources.Load<Sprite>("ferme") as Sprite;
            //Application.LoadLevel("scene2");
            // aff.text = "very good . Now you have to call for help.";
            // test = 2;

        }
        else if( test==1)
        {
            lives--;
			liveText.text = lives.ToString ();
			liveText2.text = lives.ToString ();
            //aff.text = "Oh no  you have to call for help.";

            aff.text = "Oh no  We need to minimze the quantity of air.";
            women.sprite = Resources.Load<Sprite>("women/face7t") as Sprite;

			if (lives == 0) {
				PlayerPrefs.SetInt ("Level", _Level);
				Application.LoadLevel ("Gameover");
			}

        }
        else if ( test == 2)
        {
            lives--;
			liveText.text = lives.ToString ();
			liveText2.text = lives.ToString ();
            //aff.text = "Oh no  you have to call for help.";

            aff.text = "Oh no  We need water.";
            women.sprite = Resources.Load<Sprite>("women/face7t") as Sprite;

			if (lives == 0) {
				PlayerPrefs.SetInt ("Level", _Level);
				Application.LoadLevel ("Gameover");
			}

        }


        //else
        //{
        //    lives--;
        //    aff.text = "Oh no  you have to call for help.";

        //   // aff.text = "Oh no  We need some fresh air.";
        //}




        // Update is called once per frame


    }



    public void OnMouseDown3()
    {
		
        print("wtaer");
        print("wind=" + wind);
        print("phone=" + phone);



        if ( test == 2)
		{   fire9.GetComponent<CanvasGroup>().alpha = 0;
			fire3.GetComponent<CanvasGroup>().alpha = 0;
            aff.text = "very good. Now we need to call for help";
            women.sprite = Resources.Load<Sprite>("women/face1t1") as Sprite;

            //window.sprite = Resources.Load<Sprite>("ferme") as Sprite;
            //Application.LoadLevel("scene2");
            // aff.text = "very good . Now you have to call for help.";
            // test = 2;
            test = 3;

        }
        else if ( test == 1)
        {
            lives--;
			liveText.text = lives.ToString ();
			liveText2.text = lives.ToString ();
            //aff.text = "Oh no  you have to call for help.";

            aff.text = "Oh no  We need to minimze the quantity of air.";
            women.sprite = Resources.Load<Sprite>("women/face7t") as Sprite;


			if (lives == 0) {
				PlayerPrefs.SetInt ("Level", _Level);
				Application.LoadLevel ("Gameover");
			}

        }
        else if (test == 3)
        {
            lives--;
			liveText.text = lives.ToString ();
			liveText2.text = lives.ToString ();
            //aff.text = "Oh no  you have to call for help.";

            aff.text = "Oh no  We need to call for help.";
            women.sprite = Resources.Load<Sprite>("women/face7t") as Sprite;

			if (lives == 0) {
				PlayerPrefs.SetInt ("Level", _Level);
				Application.LoadLevel ("Gameover");
			}

        }


        //else
        //{
        //    lives--;
        //    aff.text = "Oh no  you have to call for help.";

        //   // aff.text = "Oh no  We need some fresh air.";
        //}




        // Update is called once per frame

    }
	void update()
	{

		liveText.text = lives.ToString ();
		liveText2.text = lives.ToString ();

	}

}
