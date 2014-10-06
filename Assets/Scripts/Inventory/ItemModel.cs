using UnityEngine;
using System.Collections;

/// <summary>
/// Extendable Model Class. 
/// </summary>
public class ItemModel : MonoBehaviour {
	
	[SerializeField] string itemName = "item";
	public string ItemName {
		get {
			return itemName;
		}
	}

	bool inInventory = false;
	public bool InInventory {
		get {
			return inInventory;
		}
		set {
			inInventory = value;
		}
	}

	public string status = "initial";
	public Vector3 startPosition;

	//Initialize item. 
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
