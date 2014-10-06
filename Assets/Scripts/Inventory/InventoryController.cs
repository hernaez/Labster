using UnityEngine;
using System.Collections;
using System.Collections.Generic;


/// <summary>
/// Main Inventory class. Handles interactions with other classes and process the model/view
/// Singleton. Since it's a MonoBehaviour it could be dropped in the scene, so it assumes there's only one.
/// </summary>
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

	//refrences to the model/view
	InventoryView view;
	InventoryModel model;

	void Start () {
		view = this.GetComponent<InventoryView>();
		model = this.GetComponent<InventoryModel>();

	}


	/// <summary>
	/// The inventory can pick any ItemController. The method is public since the input or other systems can 
	/// tell the inventory to load an item
	/// </summary>
	/// <param name="item">Item.</param>
	public void Pick(ItemController item)
	{
		if (item != null)
		{
			model.ItemList.Add(item);
			view.Refresh(model.ItemList);
		}
	}

	/// <summary>
	/// Drops an item if it has it. It uses a string name to find it. 
	/// It's also public since any system can tell the inventory it needs something in it. 
	/// Drop only happen when the item has to be taken out of the inventory
	/// different from Hanlding, which would let the user interact with item (NOT DEVELOPED YET).
	/// </summary>
	/// <param name="item">Item.</param>
	public ItemController Drop (string itemName)
	{
		foreach (ItemController item in model.ItemList)
		{
			if (item.GetItemName() == itemName)
			{
				model.ItemList.Remove(item);
				view.Refresh(model.ItemList); //Update the view after the list changes. 
				return item; 
				//game must handle item from now on, so position, destruction or other things should be handled.
				//not inventory's responsability now.  
				//Remember to change the rendering layer also!
			}
		}

		Debug.Log("ITEM NOT FOUND");
		return null;
	}

	public List<ItemController> GetInventory()
	{
		return model.ItemList;
	}


}
