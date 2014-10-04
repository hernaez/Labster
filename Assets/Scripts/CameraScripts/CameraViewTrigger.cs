using UnityEngine;
using System.Collections;

public class CameraViewTrigger : MonoBehaviour {


	[SerializeField] Transform cameraPosition;
	[SerializeField] Transform cameraLook;
	[SerializeField] GameObject backButton;

	[SerializeField] Camera cam;
	// Use this for initialization
	void Start () {
	}

	void OnMouseDown()
	{
		CameraSetPosition();

	}

	public void CameraSetPosition()
	{
		cam.transform.position = cameraPosition.position;
		cam.transform.LookAt(cameraLook.position);
		this.collider.enabled = false;
		//not all cameras need to set up the back transition 
		if (backButton != null)
			backButton.SetActive(true);
	}


	public void ResetCollider()
	{
		this.collider.enabled = true;
	}

	// Update is called once per frame
	void Update () {
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawLine(cameraPosition.position, cameraLook.position);
	}

}
