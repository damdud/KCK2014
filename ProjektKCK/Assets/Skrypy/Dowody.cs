using UnityEngine;
using System.Collections;

public class Dowody : MonoBehaviour {
	float x=0; 
	void OnColliderStay(Collider col)
	{

		x += Time.deltaTime;
		if (x > 3.0) {
			Debug.Log ("Udalo sie zebrac dowod");

				}
	}
}
