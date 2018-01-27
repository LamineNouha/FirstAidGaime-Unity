using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class SaveLoadManager {

	public static void SavePlayer()
	{Debug.Log("saving player");
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream stream = new FileStream (Application.persistentDataPath + "/play.sav", FileMode.Create);
		PlayerData data = new PlayerData ();
		bf.Serialize (stream, data);
		stream.Close ();
	}
	public static int[] Load()
	{
		if (File.Exists (Application.persistentDataPath + "/play.sav")) {

			BinaryFormatter bf = new BinaryFormatter ();
			FileStream stream = new FileStream (Application.persistentDataPath + "/play.sav", FileMode.Open);
			Debug.Log("loading persistent data");
			PlayerData data = bf.Deserialize (stream) as PlayerData;
			stream.Close ();
			//Debug.Log(data.StarsMap[0] + "  jjjjjjjjjjjjjjjjj");
			return data.StarsMap;
		} else
			return null;
	}
		
}
[Serializable]
public class PlayerData{

	public int[] StarsMap;
	public PlayerData()
	{	
		StarsMap = SelectLevelScript.StarsMap;


	}
}
