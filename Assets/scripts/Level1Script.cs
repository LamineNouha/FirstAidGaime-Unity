using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1Script : MonoBehaviour {



	void Awake() {
		DontDestroyOnLoad(this);
	}

	public void nextlevel()
	{Application.LoadLevel("World1");
	}
	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	}


