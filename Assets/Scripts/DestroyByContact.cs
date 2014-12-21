using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {

	public GameObject explosionHazzard;
	public GameObject explosionPlayer;
	

	void OnTriggerEnter(Collider other) {

		if (other.CompareTag ("hazzard"))
		{
			Debug.Log ("Hazzard detected");
			Instantiate(explosionHazzard, transform.position, Quaternion.identity);
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
		else if(other.CompareTag("Player"))
		{
			Debug.Log ("Player Detected");
			Instantiate(explosionHazzard, transform.position, Quaternion.identity);
			Instantiate(explosionPlayer, transform.position, Quaternion.identity);
			
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
		else if(other.CompareTag("shoot"))
		{
			Debug.Log ("Shoot Detected");
			Instantiate(explosionHazzard, transform.position, Quaternion.identity);
			Destroy(other.gameObject);
			Destroy(gameObject);
		}

	}
}
