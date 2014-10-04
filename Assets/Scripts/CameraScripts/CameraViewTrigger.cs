using UnityEngine;
using System.Collections;

public class CameraViewTrigger : MonoBehaviour {


	[SerializeField] Transform cameraPosition;
	[SerializeField] Transform cameraLook;
	[SerializeField] GameObject backButton;

	private Camera cam;
	// Use this for initialization
	void Start () {
		//we assume there's going to be one camera in the scene.
		cam = Camera.main;
		if (null == cam)
			Debug.LogError("NO CAMERA IN SCENE");
	}

	void OnMouseDown()
	{
		CameraSetPosition();

	}

	public void CameraSetPosition()
	{
		cam.transform.position = cameraPosition.position;
		cam.transform.LookAt(cameraLook.position);
		//not all cameras need to set up the back transition 
		if (backButton != null)
			backButton.SetActive(true);
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
