using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

//  This script will be updated in Part 2 of this 2 part series.
public class TestModalWindow : MonoBehaviour {
	private ModalPanel modalPanel;
	//private DisplayManager displayManager;

	private UnityAction myYesAction;
	private UnityAction myNoAction;
	//private UnityAction myCancelAction;

	void Awake () {
		modalPanel = ModalPanel.Instance ();
	//	displayManager = DisplayManager.Instance ();

		myYesAction = new UnityAction (TestYesFunction);
		myNoAction = new UnityAction (TestNoFunction);
		SaveLoadManager.SavePlayer ();
		//myCancelAction = new UnityAction (TestCancelFunction);
	}

	//  Send to the Modal Panel to set up the Buttons and Functions to call
	public void TestYNC () {
		modalPanel.Choice ("Are you sure man?", TestYesFunction, TestNoFunction);
		//      modalPanel.Choice ("Would you like a poke in the eye?\nHow about with a sharp stick?", myYesAction, myNoAction, myCancelAction);
	}

	//  These are wrapped into UnityActions
	void TestYesFunction () {
		SaveLoadManager.SavePlayer ();
		Application.Quit ();
	}

	void TestNoFunction () {
		SaveLoadManager.SavePlayer ();
		modalPanel.ClosePanel ();
	}


}