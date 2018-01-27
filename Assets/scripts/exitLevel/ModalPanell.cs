using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

//  This script will be updated in Part 2 of this 2 part series.
public class ModalPanell : MonoBehaviour {

	public Text question;
	public Image iconImage;
	public Button yesButton;
	public Button noButton;
	//public Button cancelButton;
	public GameObject modalPanelObject;

	private static ModalPanell modalPanell;

	public static ModalPanell Instance () {
		if (!modalPanell) {
			modalPanell = FindObjectOfType(typeof (ModalPanell)) as ModalPanell;
			if (!modalPanell)
				Debug.LogError ("There needs to be one active ModalPanel script on a GameObject in your scene.");
		}

		return modalPanell;
	}

	// Yes/No/Cancel: A string, a Yes event, a No event and Cancel event
	public void Choice (string question, UnityAction yesEvent, UnityAction noEvent) {
		modalPanelObject.SetActive (true);

		yesButton.onClick.RemoveAllListeners();
		yesButton.onClick.AddListener (yesEvent);
		yesButton.onClick.AddListener (ClosePanel);

		noButton.onClick.RemoveAllListeners();
		noButton.onClick.AddListener (noEvent);
		noButton.onClick.AddListener (ClosePanel);

		//cancelButton.onClick.RemoveAllListeners();
		//cancelButton.onClick.AddListener (cancelEvent);
		//cancelButton.onClick.AddListener (ClosePanel);

		this.question.text = question;

		this.iconImage.gameObject.SetActive (false);
		yesButton.gameObject.SetActive (true);
		noButton.gameObject.SetActive (true);
		//cancelButton.gameObject.SetActive (true);
	}

	public void ClosePanel () {
		modalPanelObject.SetActive (false);
	}
}
