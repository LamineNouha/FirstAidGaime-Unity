using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
public class QuizzManager : MonoBehaviour {
    public  Text aff, op1,op2,op3;
	public bool loadQ2, loadQ3;
	int correctans;

    // Use this for initialization
    void Start () {
		loadQ2 = false;
		loadQ3 = false;
		correctans = 1;
		aff = GameObject.Find ("Text").GetComponent<Text> ();
		op1 = GameObject.Find ("Textop1").GetComponent<Text> ();
		op2 = GameObject.Find ("Textop2").GetComponent<Text> ();
		op3 = GameObject.Find ("Textop3").GetComponent<Text> ();
		aff.text = "In case of a car accident," +
		"\n" +
		"what should you do first?";

		op1.text = "Protect the scene of the accident.";
		op2.text = "Check if the victim is alive" +
		"\n" +
		"and give him/her some water.";
		
		op3.text = "Run away and protect yourself.";

	}
	public void Intouch1()
	{
		if (!loadQ2 && !loadQ3) {
			loadQ2 = true;
			aff.text = "Now, in case of a fire," +
				"\n" +
				"what should you do first?";

			op1.text = "Open all windows.";
			op2.text = "Close all windows.";
			op3.text = "Run away and protect yourself.";

		}
	}

	public void Intouch2()
	{
		if (loadQ2 && !loadQ3) {
			loadQ3 = true;
			aff.text = "What if we had a gas leak, " +
				"\n" +
				"what should you do first?";

			op1.text = "Close all windows.";
			op2.text = "Stay down.";
			op3.text = "Open all windows.";

		}
		
	}
	public void Intouch3()
	{
		if (loadQ3) {
			aff.text = "Correct!, you did well";
			op1.text = "Good";
			op2.text = "Great";
			op3.text = "Amazing";


		}
		
	}
}
