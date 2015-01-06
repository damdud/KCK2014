using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Poruszanie : MonoBehaviour
{

		float dystans;
		public Transform[] miejsce;
		public  InputField myInput;
		int x = 0;
		float moveSpeed = 30.0f;
		float rotateSpeed = 1.0f;
		public GameObject inspektor;
		public  Text trueDowod;
		public  Text falseDowod;
		bool zmiennaBool;
		public static int Kowalski;
		public static int Kowalska;
		public static int Nowak;
		public static int Szymanski;
		public static int Lech;
		public static int Malinowska;
		public static int zmienne;
		bool zmiennaBool2 = true;
		public bool[] miejsceBool;
		string inputValue;
		float timer ;
		public GameObject Spawner;
		int randomNumber;
		

		public void Wyswietl()
		{
		  if (dystans >50 && miejsceBool[x])
		  falseDowod.text = "Już tu byłem. Chodźmy gdzieś indziej.";

		}

		public void Pobierz (){
		inputValue = myInput.text;
		myInput.text = "";
		}
		void Start ()
		{
				trueDowod.text = "";
				falseDowod.text = "";
				inputValue = "";
				
		}

		public void randomBoolean ()
		{
			if (zmiennaBool2) {
						if (Random.value >= 0.5) {
								zmiennaBool = true;
						} else
								zmiennaBool = false;
				}
		}

		public void Update ()
		{
		Debug.Log (zmiennaBool);
				
				//string inputValue = myInput.text;
				if (inputValue == "idz" || inputValue == "idz do" || inputValue == "idz " || inputValue == "idz do ") {
						Debug.Log ("Zly format komendy");		
				} else if (inputValue == "")
						inspektor.transform.position = Spawner.transform.position;
				else if (inputValue != "idz do sofa" && inputValue != "idz do stol1" && inputValue != "idz do stol2" && inputValue != "idz do stol3" && inputValue != "idz do stol4" && inputValue != "idz do stol5" && inputValue != "idz do stol6" && inputValue != "idz do stol7" && inputValue != "idz do stol8" && inputValue !="wyjdz z budynku")
						inspektor.transform.position = Spawner.transform.position;
				else {
						switch (inputValue) {
						
						case "idz do sofa":
								x = 0;
								break;
						case "idz do hangar1":
								x=0;
								break;
						case "idz do stol1":
								x = 1;
								break;
						case "idz do hangar2":
								x=1;
								break;
						case "idz do stol2":
								x = 2;
								break;
						case "idz do hangar3":
								x = 2;
								break;
						case "idz do stol3":
								x = 3;
								break;
						case "idz do hangar4":
								x = 3;
								break;
						case "idz do stol4":
								x = 4;
								break;
						case "idz do hangar5":
								x = 4;
								break;
						case "idz do stol5":
								x = 5;
								break;
						case "idz do hangar6":
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
						case "wyjdz z budynku":
								x = 9;
								break;
						}
						
						dystans = Vector3.Distance (inspektor.transform.position, miejsce [x].position);
						//Debug.Log (dystans);
							 if (dystans >= 50 && miejsce[x].transform.gameObject.tag != "Pusty"   ) {
				
							inspektor.transform.rotation = Quaternion.Slerp (inspektor.transform.rotation, Quaternion.LookRotation (inspektor.transform.position - miejsce [x].position), rotateSpeed * Time.deltaTime);
							inspektor.transform.position += -inspektor.transform.forward * moveSpeed * Time.deltaTime;	
							if(x==9 && dystans >=49 && dystans <=51) Application.LoadLevel("mapa");
						}
						
						if (dystans >= 48 && dystans <= 52 && miejsce [x].transform.gameObject.tag != "Pusty" && zmiennaBool2 && x!= 9 )
						{
							trueDowod.text = "Poczekaj chwilę, sprawdzę czy jest tu jakiś dowód.";
							timer += Time.deltaTime;
							
							if(timer>=3.0){
								
								randomBoolean();
								zmiennaBool2 = false;
								if(zmiennaBool)
								{
									trueDowod.text = "Znalazłem dowód. Dopasujmy go do sprawdzy i \nchodzmy szukać dalej. Przestępca\njest wciąż na wolności";
									miejsce[x].transform.gameObject.tag = "Pusty";									
									miejsceBool[x] = true;
									
									
									
							//		Debug.Log (x);
									
								}
								else {
									trueDowod.text = "";
									falseDowod.text = "Nie znalazłem tutaj nic przydatnego.\nChodzmy szukac dalej.";
									miejsce[x].transform.gameObject.tag = "Pusty";
									miejsceBool[x] = true;
									
									
									
								}
							}
						}
						
						
						
						if(dystans >=52){
							trueDowod.text = "";
							falseDowod.text = "";
							zmiennaBool2 = true;
							
							timer =0.0f;
							
						}
						
					}
			}
		public void dopasujDowod()
		{
		  	if (inputValue == "dopasuj dowod") {
						if (zmiennaBool && dystans >= 48 && dystans <= 52) {
								randomNumber = Random.Range (0, 5);
								switch (randomNumber) {
								case 0:
										Kowalski = Kowalski + 1;
										break;
								case 1:
										Kowalska = Kowalska + 1;
										break;
								case 2:
										Nowak = Nowak + 1;
										break;
								case 3:
										Szymanski = Szymanski + 1;
										break;
								case 4:
										Lech = Lech + 1;
										break;
								case 5:
										Malinowska = Malinowska + 1;
										break;
								}

						}
			else if (zmiennaBool==false && dystans >= 48 && dystans <= 52) falseDowod.text = "Przeciez nie ma tu dowodu";
				}
		Debug.Log ("Kowalska: " + Kowalska);
		Debug.Log ("Szymanski: " + Szymanski);
		Debug.Log ("Kowalski: " + Kowalski);
		Debug.Log ("Nowak: " + Nowak);
		Debug.Log ("Lech: " + Lech);
		Debug.Log ("Malinowska: " + Malinowska);

		}





}








