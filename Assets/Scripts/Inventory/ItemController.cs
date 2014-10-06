using UnityEngine;
using System.Collections;

public class ItemController : MonoBehaviour {

	ItemModel model;

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
		if (false == model.InInventory)
			PickUp();
	}

	public string GetItemName()
	{
		return model.ItemName;
	}

	//user clicks on the item and it's loaded in the Inventory
	void PickUp()
	{
		model.InInventory = true;
		InventoryController.instance.Pick(this);

	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
