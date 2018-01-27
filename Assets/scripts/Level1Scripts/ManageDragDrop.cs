using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ManageDragDrop : MonoBehaviour {
	Vector3 initialPosition;
	public Text aff;
    public string nextlevel,stars;
    public static int lives;
    public Text liveText;
    public int i = 0;
    public GameObject ob;
	public string[] TestTabEF;
	public string[] TestTabGS;
	public string[] Placeholders;
	public float[] Distances;
	string t10;
	public GameObject[] placehold;
    //public AudioSource sound;
    private LayerMask layerMask = 1 << 4;

	public int _Level=1;
	public int _win;
	public GameObject Panel;


    // Use this for initialization
    void Start () {
		_win = 0;

		t10 = "k";
		TestTabEF = new string[17];
		TestTabGS = new string[17];
		Placeholders = new string[10];
		placehold = new GameObject[10];
		Distances = new float[10];
		for (int i = 0; i < 10; i++) {
			Placeholders[i] = "pel" + (i + 1).ToString ();

		}
		for (int i = 0; i < 17; i++) {
			TestTabEF [i] = "empty";
			TestTabGS [i] = "go";
		
		}

		initialPosition = gameObject.transform.position;
		aff = GameObject.Find ("Text").GetComponent<Text> ();
	
        //		print (initialPosition);
		lives = PlayerPrefs.GetInt("Lives");
        liveText.text = lives.ToString();

    

}

	public void Help()
	{
		Panel.SetActive (true);
	}
	public void exitHelp()
	{
		Panel.SetActive (false);
	}
    // Update is called once per frame
    void Update()
    {

        //touchobject1();
    }

	public int min(float [] t)
	{
		float m = t [0];
		int p = 0;
		for (int i = 1; i < t.Length; i++) {

			if (t [i] < m) {
				m = t [i];p = i;
			}
		}
		return p;
	} 


    public void Drag (){
		//store position of mouse
		if (TestTabGS[0].Equals("go")) {
			GameObject.Find ("el10").transform.position = Input.mousePosition;
		}
		aff.text = "Anti-pain";
	}
	
	public void Drop (){
		for (int i = 0; i < 10; i++) {
			placehold[i] = GameObject.Find (Placeholders[i]);
			Distances[i] = Vector2.Distance (GameObject.Find ("el10").transform.position, placehold[i].transform.position);
		}
		//float distance = Vector2.Distance (GameObject.Find ("el10").transform.position, placehold.transform.position);
		//print ("distance =" + distance);
		int x = min(Distances);	
		if (Distances [x] < 50) {
			print ("In if statement!");
			if (TestTabEF [x].Equals("empty")) {
				GameObject.Find ("el10").transform.position = placehold [x].transform.position;
				TestTabEF [x] = "full";
				TestTabGS[0] = "stop";

			}
				}
		 else {
				
			print ("In else statement!" + t10);
		}
	}


	public void Drage1 (){
		//store position of mouse
		//GameObject.Find("el1").transform.position = Input.mousePosition;
		//aff.text = "We use this one in case of bruns";
//store position of mouse
			if (TestTabGS[1].Equals("go")) {
				GameObject.Find ("el1").transform.position = Input.mousePosition;
			}
		aff.text = "An antiseptic to disinfect a wound";
	}


	public void Drop1 (){
	/*	GameObject placehold = GameObject.Find ("pel1");
		float distance = Vector2.Distance (GameObject.Find ("el1").transform.position, placehold.transform.position);
		//	print ("distance =" + distance);

		if (distance < 50) {
			GameObject.Find ("el1").transform.position = placehold.transform.position;
			aff.text = "Good job!";
			print ("In if statement! distance<50!");
			i++;
		} else {
			print ("In else statement!");
		}*/

		for (int i = 0; i < 10; i++) {
			placehold[i] = GameObject.Find (Placeholders[i]);
			Distances[i] = Vector2.Distance (GameObject.Find ("el1").transform.position, placehold[i].transform.position);
		}
		//float distance = Vector2.Distance (GameObject.Find ("el10").transform.position, placehold.transform.position);
		//print ("distance =" + distance);
		int x = min(Distances);	
		if (Distances [x] < 50) {
			print ("In if statement!");
			if (TestTabEF [x].Equals("empty")) {
				GameObject.Find ("el1").transform.position = placehold [x].transform.position;
				TestTabEF [x] = "full";
				TestTabGS[1] = "stop";

			}
		}
		else {

			print ("In else statement!" + t10);
		}

	}

	public void Drage2 (){
		if (TestTabGS[2].Equals("go")) {
			GameObject.Find ("el2").transform.position = Input.mousePosition;
		}
		aff.text = "Various sized dressings for small wounds";
	}


	public void Drop2 (){
		for (int i = 0; i < 10; i++) {
			placehold[i] = GameObject.Find (Placeholders[i]);
			Distances[i] = Vector2.Distance (GameObject.Find ("el2").transform.position, placehold[i].transform.position);
		}
		int x = min(Distances);	
		if (Distances [x] < 50) {
			print ("In if statement!");
			if (TestTabEF [x].Equals("empty")) {
				GameObject.Find ("el2").transform.position = placehold [x].transform.position;
				TestTabEF [x] = "full";
				TestTabGS[2] = "stop";

			}
		}
		else {

			print ("In else statement!" + t10);
		}
	}

	public void Drage3 (){
		if (TestTabGS[3].Equals("go")) {
			GameObject.Find ("el3").transform.position = Input.mousePosition;
		}
		aff.text = "Latex gloves";
	}



	public void Drop3 (){
		for (int i = 0; i < 10; i++) {
			placehold[i] = GameObject.Find (Placeholders[i]);
			Distances[i] = Vector2.Distance (GameObject.Find ("el3").transform.position, placehold[i].transform.position);
		}
		int x = min(Distances);	
		if (Distances [x] < 50) {
			print ("In if statement!");
			if (TestTabEF [x].Equals("empty")) {
				GameObject.Find ("el3").transform.position = placehold [x].transform.position;
				TestTabEF [x] = "full";
				TestTabGS[3] = "stop";

			}
		}
		else {

			print ("In else statement!" + t10);
		}
	}
	public void Drage4 (){
		if (TestTabGS[4].Equals("go")) {
			GameObject.Find ("el4").transform.position = Input.mousePosition;
		}
		aff.text = "Sterile compresses";
	}

	public void Drop4 (){
		for (int i = 0; i < 10; i++) {
			placehold[i] = GameObject.Find (Placeholders[i]);
			Distances[i] = Vector2.Distance (GameObject.Find ("el4").transform.position, placehold[i].transform.position);
		}
		int x = min(Distances);	
		if (Distances [x] < 50) {
			print ("In if statement!");
			if (TestTabEF [x].Equals("empty")) {
				GameObject.Find ("el4").transform.position = placehold [x].transform.position;
				TestTabEF [x] = "full";
				TestTabGS[4] = "stop";

			}
		}
		else {

			print ("In else statement!" + t10);
		}
	}
	public void Drage5 (){
		if (TestTabGS[5].Equals("go")) {
			GameObject.Find ("el5").transform.position = Input.mousePosition;
		}
		aff.text = "A needle";
	}

	public void Drop5 (){
		for (int i = 0; i < 10; i++) {
			placehold[i] = GameObject.Find (Placeholders[i]);
			Distances[i] = Vector2.Distance (GameObject.Find ("el5").transform.position, placehold[i].transform.position);
		}
		int x = min(Distances);	
		if (Distances [x] < 50) {
			print ("In if statement!");
			if (TestTabEF [x].Equals("empty")) {
				GameObject.Find ("el5").transform.position = placehold [x].transform.position;
				TestTabEF [x] = "full";
				TestTabGS[5] = "stop";

			}
		}
		else {

			print ("In else statement!" + t10);
		}
	}

	public void Drage6 (){
		if (TestTabGS[6].Equals("go")) {
			GameObject.Find ("el6").transform.position = Input.mousePosition;
		}
		aff.text = "Hemostatic dressing to stop haemorrhage";
	}

	public void Drop6 (){
		for (int i = 0; i < 10; i++) {
			placehold[i] = GameObject.Find (Placeholders[i]);
			Distances[i] = Vector2.Distance (GameObject.Find ("el6").transform.position, placehold[i].transform.position);
		}
		int x = min(Distances);	
		if (Distances [x] < 50) {
			print ("In if statement!");
			if (TestTabEF [x].Equals("empty")) {
				GameObject.Find ("el6").transform.position = placehold [x].transform.position;
				TestTabEF [x] = "full";
				TestTabGS[6] = "stop";

			}
		}
		else {

			print ("In else statement!" + t10);
		}
	}

	public void Drage7 (){
		if (TestTabGS[7].Equals("go")) {
			GameObject.Find ("el7").transform.position = Input.mousePosition;
		}
		aff.text = "A bondage roll";
	}


	public void Drop7 (){
		for (int i = 0; i < 10; i++) {
			placehold[i] = GameObject.Find (Placeholders[i]);
			Distances[i] = Vector2.Distance (GameObject.Find ("el7").transform.position, placehold[i].transform.position);
		}
		int x = min(Distances);	
		if (Distances [x] < 50) {
			print ("In if statement!");
			if (TestTabEF [x].Equals("empty")) {
				GameObject.Find ("el7").transform.position = placehold [x].transform.position;
				TestTabEF [x] = "full";
				TestTabGS[7] = "stop";

			}
		}
		else {

			print ("In else statement!" + t10);
		}
	}

	public void Drage8 (){
		if (TestTabGS[8].Equals("go")) {
			GameObject.Find ("el8").transform.position = Input.mousePosition;
		}
		aff.text = "Your personal medications";
	}


	public void Drop8 (){
		for (int i = 0; i < 10; i++) {
			placehold[i] = GameObject.Find (Placeholders[i]);
			Distances[i] = Vector2.Distance (GameObject.Find ("el8").transform.position, placehold[i].transform.position);
		}
		int x = min(Distances);	
		if (Distances [x] < 50) {
			print ("In if statement!");
			if (TestTabEF [x].Equals("empty")) {
				GameObject.Find ("el8").transform.position = placehold [x].transform.position;
				TestTabEF [x] = "full";
				TestTabGS[8] = "stop";

			}
		}
		else {

			print ("In else statement!" + t10);
		}
	}

	public void Drage9 (){
		if (TestTabGS[9].Equals("go")) {
			GameObject.Find ("el9").transform.position = Input.mousePosition;
		}
		aff.text = "Scissors for cutting bondage, dressings, ...";
	}
	public void Drop9 (){
		for (int i = 0; i < 10; i++) {
			placehold[i] = GameObject.Find (Placeholders[i]);
			Distances[i] = Vector2.Distance (GameObject.Find ("el9").transform.position, placehold[i].transform.position);
		}
		int x = min(Distances);	
		if (Distances [x] < 50) {
			print ("In if statement!");
			if (TestTabEF [x].Equals("empty")) {
				GameObject.Find ("el9").transform.position = placehold [x].transform.position;
				TestTabEF [x] = "full";
				TestTabGS[9] = "stop";

			}
		}
		else {

			print ("In else statement!" + t10);
		}
	}

	public void Drage11 (){
		if (TestTabGS[11].Equals("go")) {
			GameObject.Find ("el11").transform.position = Input.mousePosition;
		}
		aff.text = "A knife";
	}
	public void Drop11 (){
		for (int i = 0; i < 10; i++) {
			placehold[i] = GameObject.Find (Placeholders[i]);
			Distances[i] = Vector2.Distance (GameObject.Find ("el11").transform.position, placehold[i].transform.position);
		}
		int x = min(Distances);	
		if (Distances [x] < 50) {
			print ("In if statement!");
			if (TestTabEF [x].Equals("empty")) {
				GameObject.Find ("el11").transform.position = placehold [x].transform.position;
				TestTabEF [x] = "full";
				TestTabGS[11] = "stop";

			}
		}
		else {

			print ("In else statement!" + t10);
		}
	}
	public void Drage12 (){
		if (TestTabGS[12].Equals("go")) {
			GameObject.Find ("el12").transform.position = Input.mousePosition;
		}
		aff.text = "A mobile phone\n";
	}
	public void Drop12 (){
		for (int i = 0; i < 10; i++) {
			placehold[i] = GameObject.Find (Placeholders[i]);
			Distances[i] = Vector2.Distance (GameObject.Find ("el12").transform.position, placehold[i].transform.position);
		}
		int x = min(Distances);	
		if (Distances [x] < 50) {
			print ("In if statement!");
			if (TestTabEF [x].Equals("empty")) {
				GameObject.Find ("el12").transform.position = placehold [x].transform.position;
				TestTabEF [x] = "full";
				TestTabGS[12] = "stop";

			}
		}
		else {

			print ("In else statement!" + t10);
		}
	}
	public void Drage13 (){
		if (TestTabGS[13].Equals("go")) {
			GameObject.Find ("el13").transform.position = Input.mousePosition;
		}
		aff.text = "A ruler";
	}
	public void Drop13 (){
		for (int i = 0; i < 10; i++) {
			placehold[i] = GameObject.Find (Placeholders[i]);
			Distances[i] = Vector2.Distance (GameObject.Find ("el13").transform.position, placehold[i].transform.position);
		}
		int x = min(Distances);	
		if (Distances [x] < 50) {
			print ("In if statement!");
			if (TestTabEF [x].Equals("empty")) {
				GameObject.Find ("el13").transform.position = placehold [x].transform.position;
				TestTabEF [x] = "full";
				TestTabGS[13] = "stop";

			}
		}
		else {

			print ("In else statement!" + t10);
		}
	}
	public void Drage14 (){
		if (TestTabGS[14].Equals("go")) {
			GameObject.Find ("el14").transform.position = Input.mousePosition;
		}
		aff.text = "Adjustable wrench";
	}
	public void Drop14 (){
		for (int i = 0; i < 10; i++) {
			placehold[i] = GameObject.Find (Placeholders[i]);
			Distances[i] = Vector2.Distance (GameObject.Find ("el14").transform.position, placehold[i].transform.position);
		}
		int x = min(Distances);	
		if (Distances [x] < 50) {
			print ("In if statement!");
			if (TestTabEF [x].Equals("empty")) {
				GameObject.Find ("el14").transform.position = placehold [x].transform.position;
				TestTabEF [x] = "full";
				TestTabGS[14] = "stop";

			}
		}
		else {

			print ("In else statement!" + t10);
		}
	}
	public void Drage15 (){
		if (TestTabGS[15].Equals("go")) {
			GameObject.Find ("el15").transform.position = Input.mousePosition;
		}
		aff.text = "A banana";
	}
	public void Drop15 (){
		for (int i = 0; i < 10; i++) {
			placehold[i] = GameObject.Find (Placeholders[i]);
			Distances[i] = Vector2.Distance (GameObject.Find ("el15").transform.position, placehold[i].transform.position);
		}
		int x = min(Distances);	
		if (Distances [x] < 50) {
			print ("In if statement!");
			if (TestTabEF [x].Equals("empty")) {
				GameObject.Find ("el15").transform.position = placehold [x].transform.position;
				TestTabEF [x] = "full";
				TestTabGS[15] = "stop";

			}
		}
		else {

			print ("In else statement!" + t10);
		}
	}


	public void Drage16 (){
		if (TestTabGS[16].Equals("go")) {
			GameObject.Find ("el16").transform.position = Input.mousePosition;
		}
		aff.text = "A survival blanket to keep a victim warm";
	}
	public void Drop16 (){
		for (int i = 0; i < 10; i++) {
			placehold[i] = GameObject.Find (Placeholders[i]);
			Distances[i] = Vector2.Distance (GameObject.Find ("el16").transform.position, placehold[i].transform.position);
		}
		int x = min(Distances);	
		if (Distances [x] < 50) {
			print ("In if statement!");
			if (TestTabEF [x].Equals("empty")) {
				GameObject.Find ("el16").transform.position = placehold [x].transform.position;
				TestTabEF [x] = "full";
				TestTabGS[16] = "stop";

			}
		}
		else {

			print ("In else statement!" + t10);
		}
	}

    public void touchobject1()
	{  Debug.Log ("positionnnnnnnnnnnn1"+GameObject.Find ("pel1").transform.position);
		Debug.Log ("positionnnnnnnnnnnn2"+GameObject.Find ("el1").transform.position);

	
       
		if (((GameObject.Find ("el1").transform.position - GameObject.Find ("pel1").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el2").transform.position - GameObject.Find ("pel1").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el3").transform.position - GameObject.Find ("pel1").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el2").transform.position - GameObject.Find ("pel1").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el3").transform.position - GameObject.Find ("pel1").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el4").transform.position - GameObject.Find ("pel1").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el16").transform.position - GameObject.Find ("pel1").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el6").transform.position - GameObject.Find ("pel1").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el7").transform.position - GameObject.Find ("pel1").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el8").transform.position - GameObject.Find ("pel1").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el9").transform.position - GameObject.Find ("pel1").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el10").transform.position - GameObject.Find ("pel1").transform.position).magnitude <= 0.1) &&

		    ((GameObject.Find ("el1").transform.position - GameObject.Find ("pel2").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el2").transform.position - GameObject.Find ("pel2").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el3").transform.position - GameObject.Find ("pel2").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el2").transform.position - GameObject.Find ("pel2").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el3").transform.position - GameObject.Find ("pel2").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el4").transform.position - GameObject.Find ("pel2").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el16").transform.position - GameObject.Find ("pel2").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el6").transform.position - GameObject.Find ("pel2").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el7").transform.position - GameObject.Find ("pel2").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el8").transform.position - GameObject.Find ("pel2").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el9").transform.position - GameObject.Find ("pel2").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el10").transform.position - GameObject.Find ("pel2").transform.position).magnitude <= 0.1) &&

		    ((GameObject.Find ("el1").transform.position - GameObject.Find ("pel3").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el2").transform.position - GameObject.Find ("pel3").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el3").transform.position - GameObject.Find ("pel3").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el2").transform.position - GameObject.Find ("pel3").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el3").transform.position - GameObject.Find ("pel3").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el4").transform.position - GameObject.Find ("pel3").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el16").transform.position - GameObject.Find ("pel3").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el6").transform.position - GameObject.Find ("pel3").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el7").transform.position - GameObject.Find ("pel3").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el8").transform.position - GameObject.Find ("pel3").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el9").transform.position - GameObject.Find ("pel3").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el10").transform.position - GameObject.Find ("pel3").transform.position).magnitude <= 0.1) &&


		    ((GameObject.Find ("el1").transform.position - GameObject.Find ("pel4").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el2").transform.position - GameObject.Find ("pel4").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el3").transform.position - GameObject.Find ("pel4").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el2").transform.position - GameObject.Find ("pel4").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el3").transform.position - GameObject.Find ("pel4").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el4").transform.position - GameObject.Find ("pel4").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el16").transform.position - GameObject.Find ("pel4").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el6").transform.position - GameObject.Find ("pel4").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el7").transform.position - GameObject.Find ("pel4").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el8").transform.position - GameObject.Find ("pel4").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el9").transform.position - GameObject.Find ("pel4").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el10").transform.position - GameObject.Find ("pel4").transform.position).magnitude <= 0.1) &&

		    ((GameObject.Find ("el1").transform.position - GameObject.Find ("pel5").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el2").transform.position - GameObject.Find ("pel5").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el3").transform.position - GameObject.Find ("pel5").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el2").transform.position - GameObject.Find ("pel5").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el3").transform.position - GameObject.Find ("pel5").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el4").transform.position - GameObject.Find ("pel5").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el16").transform.position - GameObject.Find ("pel5").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el6").transform.position - GameObject.Find ("pel5").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el7").transform.position - GameObject.Find ("pel5").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el8").transform.position - GameObject.Find ("pel5").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el9").transform.position - GameObject.Find ("pel5").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el10").transform.position - GameObject.Find ("pel5").transform.position).magnitude <= 0.1) &&

		    ((GameObject.Find ("el1").transform.position - GameObject.Find ("pel6").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el2").transform.position - GameObject.Find ("pel6").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el3").transform.position - GameObject.Find ("pel6").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el2").transform.position - GameObject.Find ("pel6").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el3").transform.position - GameObject.Find ("pel6").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el4").transform.position - GameObject.Find ("pel6").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el16").transform.position - GameObject.Find ("pel6").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el6").transform.position - GameObject.Find ("pel6").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el7").transform.position - GameObject.Find ("pel6").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el8").transform.position - GameObject.Find ("pel6").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el9").transform.position - GameObject.Find ("pel6").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el10").transform.position - GameObject.Find ("pel6").transform.position).magnitude <= 0.1) &&


		    ((GameObject.Find ("el1").transform.position - GameObject.Find ("pel7").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el2").transform.position - GameObject.Find ("pel7").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el3").transform.position - GameObject.Find ("pel7").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el2").transform.position - GameObject.Find ("pel7").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el3").transform.position - GameObject.Find ("pel7").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el4").transform.position - GameObject.Find ("pel7").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el16").transform.position - GameObject.Find ("pel7").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el6").transform.position - GameObject.Find ("pel7").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el7").transform.position - GameObject.Find ("pel7").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el8").transform.position - GameObject.Find ("pel7").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el9").transform.position - GameObject.Find ("pel7").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el10").transform.position - GameObject.Find ("pel7").transform.position).magnitude <= 0.1) &&


		    ((GameObject.Find ("el1").transform.position - GameObject.Find ("pel8").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el2").transform.position - GameObject.Find ("pel8").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el3").transform.position - GameObject.Find ("pel8").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el2").transform.position - GameObject.Find ("pel8").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el3").transform.position - GameObject.Find ("pel8").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el4").transform.position - GameObject.Find ("pel8").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el16").transform.position - GameObject.Find ("pel8").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el6").transform.position - GameObject.Find ("pel8").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el7").transform.position - GameObject.Find ("pel8").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el8").transform.position - GameObject.Find ("pel8").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el9").transform.position - GameObject.Find ("pel8").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el10").transform.position - GameObject.Find ("pel8").transform.position).magnitude <= 0.1) &&


		    ((GameObject.Find ("el1").transform.position - GameObject.Find ("pel9").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el2").transform.position - GameObject.Find ("pel9").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el3").transform.position - GameObject.Find ("pel9").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el2").transform.position - GameObject.Find ("pel9").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el3").transform.position - GameObject.Find ("pel9").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el4").transform.position - GameObject.Find ("pel9").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el16").transform.position - GameObject.Find ("pel9").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el6").transform.position - GameObject.Find ("pel9").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el7").transform.position - GameObject.Find ("pel9").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el8").transform.position - GameObject.Find ("pel9").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el9").transform.position - GameObject.Find ("pel9").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el10").transform.position - GameObject.Find ("pel9").transform.position).magnitude <= 0.1) &&


		    ((GameObject.Find ("el1").transform.position - GameObject.Find ("pel10").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el2").transform.position - GameObject.Find ("pel10").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el3").transform.position - GameObject.Find ("pel10").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el2").transform.position - GameObject.Find ("pel10").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el3").transform.position - GameObject.Find ("pel10").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el4").transform.position - GameObject.Find ("pel10").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el16").transform.position - GameObject.Find ("pel10").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el6").transform.position - GameObject.Find ("pel10").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el7").transform.position - GameObject.Find ("pel10").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el8").transform.position - GameObject.Find ("pel10").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el9").transform.position - GameObject.Find ("pel10").transform.position).magnitude <= 0.1 ||
		    (GameObject.Find ("el10").transform.position - GameObject.Find ("pel10").transform.position).magnitude <= 0.1))
 {                // mettre entre les cotes le nom du collider à toucher
			Debug.Log ("positionnnnnnns okkkkkkkkkkkkk");
			//Commandes à exécuter quand on touche l'objet
			//	bat.GetComponent<Animation>().Play("Batman12");
			//StartCoroutine(toto());
			_win = 1;
			PlayerPrefs.SetInt ("Level", _Level);
			PlayerPrefs.SetInt ("Tentatives_perdues", 3 - lives);
			PlayerPrefs.SetInt ("Win", _win);
			Application.LoadLevel ("Win");

		} else { // mettre entre les cotes le nom du collider à toucher
			if (lives > 1) {
				lives = lives - 1;
				PlayerPrefs.SetInt ("Lives", lives);
				//liveText.text = lives.ToString();
				aff.text = "False answer";
				Application.LoadLevel ("Level1");
			} else {PlayerPrefs.SetInt ("Level", _Level);
				Application.LoadLevel ("Gameover");
			}
		}
               

            }

	public void Replay(){
		lives = 3;
		PlayerPrefs.SetInt ("Lives", lives);
		Application.LoadLevel ("Level1");
	}

	public void NextLevel(){
		Debug.Log ("ssssssssssss" + (3 - lives));
		PlayerPrefs.SetInt ("Tentatives_perdues", 3-lives);
		PlayerPrefs.SetInt ("Level", _Level);
		PlayerPrefs.SetInt ("Win",1);
		Application.LoadLevel ("SelectLevel");
	}
        
    
}