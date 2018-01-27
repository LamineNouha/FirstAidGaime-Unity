using UnityEngine;
using System.Collections;

public class BringToFrontl : MonoBehaviour {

	void OnEnable () {
		transform.SetAsLastSibling ();
	}
}