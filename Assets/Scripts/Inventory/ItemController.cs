using UnityEngine;
using System.Collections;

public class ItemController : MonoBehaviour {


	bool inInventory = false;
	ItemModel model;

	//TODO: Needs to load XML parameters itemName/status/position
	void Start () {
		//loads the model
		model = this.GetComponent<ItemModel>();
		if (model == null)
		{
			Debug.LogError("MODEL NOT FOUND IN ITEM " + this.name);
		}
	}

	void OnMouseDown()
	{
		if (false == inInventory)
			PickUp();
	}



	//user clicks on the item and it's loaded in the Inventory
	void PickUp()
	{
		inInventory = true;
		InventoryController.instance.Pick(this);

	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
