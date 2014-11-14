using UnityEngine;
using System.Collections;

public class levelLoad : MonoBehaviour {
	

	// Update is called once per frame
	void Update () {
	if (Input.GetKey (KeyCode.F1)) {
						Application.LoadLevel ("Komisariat");
				} else if (Input.GetKey (KeyCode.F2)) {
						Application.LoadLevel ("Sklep");
				} else if (Input.GetKey (KeyCode.F3)) {
						Application.LoadLevel ("Magazyn");
				} else if (Input.GetKey (KeyCode.F4)) {
						Application.LoadLevel ("mieszkanie");
				} else if (Input.GetKey (KeyCode.F5)) {
						Application.LoadLevel ("mieszkanie2");
				} else if (Input.GetKey (KeyCode.F6)) {
						Application.LoadLevel("mapa");
				}

	}
}
