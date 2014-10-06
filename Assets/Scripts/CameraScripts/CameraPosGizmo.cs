using UnityEngine;
using System.Collections;

public class CameraPosGizmo : MonoBehaviour {

	[SerializeField] Color sphere = Color.yellow;
	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
	
	}
	void OnDrawGizmos() {
		Gizmos.color = sphere;
		Gizmos.DrawWireSphere(transform.position, 0.3f);
	}
}
