using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
		Vector3 fwd = new Vector3 (0, 0, 1);
		rigidbody.velocity = fwd * speed;
	}
}
