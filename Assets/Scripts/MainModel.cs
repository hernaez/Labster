using UnityEngine;
using System.Collections;

/// <summary>
/// All variables are saved here.
/// When save/loading, this should be read/updated accordingly
/// </summary>
public class MainModel : MonoBehaviour {


	bool levelDone = false;

	public bool LevelDone {
		get {
			return levelDone;
		}
		set {
			levelDone = value;
		}
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
