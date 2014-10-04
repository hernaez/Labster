using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryController : MonoBehaviour {

	private static InventoryController _instance;

	public static InventoryController instance
	{
		get
		{
			//If _instance hasn't been set yet, we grab it from the scene!
			//This will only happen the first time this reference is used.
			if(_instance == null)
				_instance = GameObject.FindObjectOfType<InventoryController>();
			return _instance;
		}
	}

	InventoryView view;

	//TODO: this should be in the inventory model 
	List<ItemController> itemList;

	// Use this for initialization
	void Start () {

		itemList = new List<ItemController>();
		view = this.GetComponent<InventoryView>();
	}
	public void Pick(ItemController item)
	{
		if (item != null)
		{
			itemList.Add(item);
			view.Refresh(itemList);
		}
	}


	// Update is called once per frame
	void Update () {
	
	}

}
