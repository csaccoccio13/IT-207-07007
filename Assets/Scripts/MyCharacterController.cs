using UnityEngine;
using System.Collections;

public class MyCharacterController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = Vector3.zero;

		// Is up pressed?
		if (Input.GetKey (KeyCode.UpArrow) == true) {
			// Move character up by some amount
			direction.y += 0.1f;
		}
		// Is left pressed?
		if (Input.GetKey (KeyCode.LeftArrow) == true) {
			// Move character left by some amount
			direction.x -= 0.1f;
		}
		// Is right pressed?
		if (Input.GetKey (KeyCode.RightArrow) == true) {
			// Move character right by some amount
			direction.x += 0.1f;
		}
		// Is down pressed?
		if (Input.GetKey (KeyCode.DownArrow) == true) {
			// Move character down by some amount
			direction.y -= 0.1f;
		}
		gameObject.transform.Translate (direction);
	}
}
