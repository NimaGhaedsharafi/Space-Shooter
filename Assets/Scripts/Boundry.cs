using UnityEngine;
using System.Collections;

public class Boundry : MonoBehaviour {

	void OnTriggerExit(Collider other) {
		Destroy(other.gameObject);
	}
}
