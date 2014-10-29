using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 5;
	public float xMin;
	public float xMax;
	public float zMin;
	public float zMax;

	void FixedUpdate() {

		// Get X 
		float horizontal =  Input.GetAxis ("Horizontal");
		// Get Z
		float vertical = Input.GetAxis ("Vertical") ;

		Vector3 movement = new Vector3(horizontal, 0.0f, vertical);
		this.rigidbody.velocity = movement * speed;

		float xT ;
		float zT;

		if (this.rigidbody.position.x > xMax)
		{
			xT = xMax;
		}
		else if (this.rigidbody.position.x < xMin) {
			xT = xMin;
		} 
		else
		{
			xT = this.rigidbody.position.x;
		}

		if (this.rigidbody.position.z > zMax)
		{
			zT = zMax;
		}
		else if (this.rigidbody.position.z < zMin) {
			zT = zMin;
		}
		else
		{
			zT = this.rigidbody.position.z;
		}

		Vector3 pos = new Vector3 (xT, 0.0f, zT);

		pos = new Vector3 (
			Mathf.Clamp(this.rigidbody.position.x, xMin, xMax),
			0.0f,
			Mathf.Clamp(this.rigidbody.position.z, zMin, zMax)
		);

		this.rigidbody.position = pos;
	}

}
