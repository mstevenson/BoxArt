using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;

public class Loader : MonoBehaviour
{
	void Start ()
	{
		Load ();
	}

	public void Load ()
	{
		foreach (var dir in Directory.GetDirectories ("Boxes")) {
			string descriptor = dir + "/box.json";
			if (File.Exists (descriptor)) {
				string json = File.ReadAllText (descriptor);
//				var boxModel = JsonUtility.FromJson<BoxArt.Model.Box> (json);
				var boxModel = JsonMapper.ToObject<BoxArt.Model.Box> (json);
//				Debug.Log (boxModel.metadata);
			} else {
				Debug.LogError ("Box descriptor does not exist");
			}
		}
	}
}
