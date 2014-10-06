using UnityEngine;
using System.Collections;
using System.Collections.Generic;


/// <summary>
/// Main controller handles all main intereactions. 
/// Scene Setup, Input, etc
/// </summary>
public class MainController : MonoBehaviour {

	[SerializeField] GameObject endMessage;
	bool levelDone = false;
	MainModel mainModel;

	// Use this for initialization
	void Start () {
		mainModel = this.GetComponent<MainModel>();
		Init();

	}

	void Init()
	{
		levelDone = mainModel.LevelDone;
		endMessage.SetActive(mainModel.LevelDone);
	}

	// Update is called once per frame
	void Update () 
	{
		if (!levelDone)
			CheckForWinCondition();
	}

	/// <summary>
	/// It would be better to have a working event system where the check for win is done every time there's a 
	/// meaninful action taken (event dispatched), but for a small a quick solution, an update loop would do. 
	/// Gameplay code should be decoupled from "engine" code like the inventory, that's why we run through the
	/// items here instead.
	/// </summary>
	void CheckForWinCondition()
	{

		List<ItemController> itemList = InventoryController.instance.GetInventory();

		int itemCount = 0;
		foreach (ItemController item in itemList)
		{

			switch (item.GetItemName())
			{
				case "RedOil":
					itemCount++;
					break;
				case "BlackOil":
					itemCount++;
					break;
				case "BlueOil":
					itemCount++;
					break;
			}
		}

		if (itemCount == 3)
		{
			levelDone = true;
			Debug.Log("GAME WON");
			endMessage.SetActive(true);
		}

	}
	
}
