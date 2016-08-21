using UnityEngine;
using System.Collections;

public class AcelerometerControl : MonoBehaviour {
	
	// gravity constant
	public float g=9.8f;

	void FixedUpdate() {
		// normalize axis
		var gravity = new Vector3 (
			Input.acceleration.x,
			Input.acceleration.z,
			Input.acceleration.y
		) * g;

		GetComponent<Rigidbody>().AddForce (gravity, ForceMode.Acceleration);
	}
}
