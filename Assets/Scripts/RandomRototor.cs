using UnityEngine;
using System.Collections;

public class RandomRototor : MonoBehaviour {

	public float tumbleFact;

	// Use this for initialization
	void Start () {
		Vector3 randomPoint = new Vector3 (Random.value, Random.value, Random.value);
		this.rigidbody.angularVelocity = randomPoint * tumbleFact;
	}
}
