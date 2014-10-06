using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Data model for the Inventory. Currently only a list.
/// Should be able to be initialized by loading the level XML. 
/// </summary>
public class InventoryModel : MonoBehaviour {
	
	List<ItemController> itemList;

	public List<ItemController> ItemList {
		get {
			return itemList;
		}
	}

	// Use this for initialization
	void Start () {
		itemList = new List<ItemController>();
	}

	public void Load(List<ItemController> loadedList)
	{
		//Clear and Copy List.
		itemList = new List<ItemController>();
		foreach (ItemController item in loadedList)
			itemList.Add(item);
	}

}
