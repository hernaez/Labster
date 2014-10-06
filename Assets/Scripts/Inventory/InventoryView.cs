using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryView : MonoBehaviour {

	//list of positions to render items in the inventory. gets refreshed by the controller
	[SerializeField] List<Transform> inventoryPositions;

	// Use this for initialization
	void Start () {
		
	}

	//render the new inventory list according to the status
	public void Refresh(List<ItemController> inventory)
	{
		int i = 0;
		foreach (ItemController item in inventory)
		{

			item.transform.localScale = Vector3.one;
			//item.transform.parent = inventoryPositions[i];
			item.transform.localPosition = inventoryPositions[i].transform.position;
			item.transform.gameObject.layer = LayerMask.NameToLayer("UI");
			foreach(Transform child in item.transform)
				child.gameObject.layer = LayerMask.NameToLayer("UI");
			++i;

			//HACK: All item's should scale to perfectly match the Inventory UI. For that, a size should be 
			//stablished and the scale proportionally to it. then it would fit perfectly in the UI.  
			item.transform.localScale *= 0.25f;
		}

	}
	
}
