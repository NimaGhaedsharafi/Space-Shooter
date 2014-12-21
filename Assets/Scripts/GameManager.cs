using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	int hazzardCount = 5;
	float hazzardWait = .5f;
	float WaveWait = 1f;
	float ReadyWait = 1f;
	

	float x = 7;

	// go astroids
	public GameObject hazzard;

	// go hazzardSpawn
	public Transform hazzardSpwan;

	// Use this for initialization
	void Start () {

		StartCoroutine(hazzardWave());

	}
	

	IEnumerator hazzardWave()
	{
		yield return new WaitForSeconds(ReadyWait);
		while(true)
		{
			for(int i =0; i < hazzardCount; i++) 
			{
				Instantiate (hazzard, new Vector3 (Random.Range(x, -x), hazzardSpwan.position.y, hazzardSpwan.position.z), Quaternion.identity);
				yield return new WaitForSeconds(hazzardWait);
			}
			yield return new WaitForSeconds(WaveWait);

		}

	}
}
