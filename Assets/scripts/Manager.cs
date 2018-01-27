using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Manager : MonoBehaviour {
    public  Text aff;
    public string nextlevel, stars;
    public  int lives;
    public Text liveText;
    public Image window;
    public Image fire1, fire2, fire3, fire4, fire5, fire6, fire7, fire8, fire9, fire10, fire11;
   public  int test ;
    public bool phone ;
    public bool wind ,wat;
    public Image women,water;
    public int i = 0;
    public GameObject ob;

    // Use this for initialization
    void Start () {
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


        print("hello");
        lives = 3;
       // liveText.text = lives.ToString();


    }
    public void OnMouseDown()
    {if (wind && !phone && !wat && test==1)
        {
            window.sprite = Resources.Load<Sprite>("ouv") as Sprite;
            women.sprite = Resources.Load<Sprite>("women/face1t1") as Sprite;

            aff.text = "very good . Nowwe need some water.";
            fire11.GetComponent<CanvasGroup>().alpha = 0;
            fire2.GetComponent<CanvasGroup>().alpha = 0;
            fire10.GetComponent<CanvasGroup>().alpha = 0;
            fire9.GetComponent<CanvasGroup>().alpha = 0;
            fire7.GetComponent<CanvasGroup>().alpha = 0;

            test = 2;
            wind = false;
            phone = true;
        }
        else if( test==2 )
        {
            lives--;
            aff.text = "Oh no .....water .";
            women.sprite = Resources.Load<Sprite>("women/face7t") as Sprite;



        }
        else if (test == 3)
        {
            lives--;
            aff.text = "Oh no .you need to call for help .";
            women.sprite = Resources.Load<Sprite>("women/face7t") as Sprite;



        }

    }





    public void OnMouseDown2()
    {
        print("phone");
        print("wind=" + wind);
        print("phone=" + phone);
        if (phone && !wind &&  !wat &&test==3)
        {
            //window.sprite = Resources.Load<Sprite>("ferme") as Sprite;
            Application.LoadLevel("scene2");
            // aff.text = "very good . Now you have to call for help.";
            // test = 2;

        }
        else if( test==1)
        {
            lives--;
            //aff.text = "Oh no  you have to call for help.";

            aff.text = "Oh no  We need to minimze the quantity of air.";
            women.sprite = Resources.Load<Sprite>("women/face7t") as Sprite;



        }
        else if ( test == 2)
        {
            lives--;
            //aff.text = "Oh no  you have to call for help.";

            aff.text = "Oh no  We need water.";
            women.sprite = Resources.Load<Sprite>("women/face7t") as Sprite;



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
        {
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
            //aff.text = "Oh no  you have to call for help.";

            aff.text = "Oh no  We need to minimze the quantity of air.";
            women.sprite = Resources.Load<Sprite>("women/face7t") as Sprite;



        }
        else if (test == 3)
        {
            lives--;
            //aff.text = "Oh no  you have to call for help.";

            aff.text = "Oh no  We need to call for help.";
            women.sprite = Resources.Load<Sprite>("women/face7t") as Sprite;



        }


        //else
        //{
        //    lives--;
        //    aff.text = "Oh no  you have to call for help.";

        //   // aff.text = "Oh no  We need some fresh air.";
        //}




        // Update is called once per frame


    }


}
