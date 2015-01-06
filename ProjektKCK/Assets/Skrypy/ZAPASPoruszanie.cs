using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PoruszanieZAPAS : MonoBehaviour
{

		float dystans;
		public Transform[] miejsce;
		public InputField myInput;
		int x;
		float rotateSpeed = 1.0f;
		float moveSpeed = 30.0f;
		public GameObject inspektor;
		public Text trueDowod;
		public Text falseDowod;
		bool zmiennaBool;
		public static int Kowalski;
		public static int Kowalska;
		public static int Nowak;
		public static int Szymanski;
		public static int Lech;
		public static int Malinowska;
	int zmienne;
		void Start ()
		{
				trueDowod.text = "";
				falseDowod.text = "";
				
		}

		public void randomBoolean ()
		{
				if (Random.value >= 0.5) {
						zmiennaBool = true;
				} else
						zmiennaBool = false;
		}

		public void Update ()
		{
		Debug.Log (zmiennaBool);
				string input = myInput.text;
				if (input == "idz" || input == "idz do" || input == "idz " || input == "" || input == "idz do ") {
						Debug.Log ("Zly format komendy");		
				} else {
						switch (input) {
						case "idz do sofa":
								x = 0;
								break;
						case "idz do stol1":
								x = 1;
								break;
						case "idz do stol2":
								x = 2;
								break;
						case "idz do stol3":
								x = 3;
								break;
						case "idz do stol4":
								x = 4;
								break;
						case "idz do stol5":
								x = 5;
								break;
						case "idz do stol6":
								x = 6;
								break;
						case "idz do stol7":
								x = 7;
								break;
						case "idz do stol8":
								x = 8;
								break;
						}

						dystans = Vector3.Distance (inspektor.transform.position, miejsce [x].position);
						//Debug.Log (dystans);
						if (dystans >= 50) {
								inspektor.transform.rotation = Quaternion.Slerp (inspektor.transform.rotation, Quaternion.LookRotation (inspektor.transform.position - miejsce [x].position), rotateSpeed * Time.deltaTime);
								inspektor.transform.position += -inspektor.transform.forward * moveSpeed * Time.deltaTime;
								if (dystans >= 48 && dystans <= 52 && miejsce [x].transform.gameObject.tag != "Pusty") {
									trueDowod.text = "Sprawdz czy jest dowod";
									if(input == "szukaj dowodu")				
									{
									//	randomBoolean();
										if(zmiennaBool == true)
											{
												trueDowod.text = "Znaleziono dowod.";
												if(input == "wez dowod")
												{
													Debug.Log ("wzieto dowod");
												}
											}
										else
											{
												trueDowod.text = "";
												falseDowod.text = "Niestety nie znaleziono dowodu.";
											}
									}
													

								}																	
						}
					if(dystans >=52){
						trueDowod.text = "";
						falseDowod.text = "";
					}
					
				}
		}


		public void search()
	{

	}

		IEnumerator timer()
		{
		yield return new WaitForSeconds (3);
		trueDowod.text = "";
		falseDowod.text = "";
		}
}








