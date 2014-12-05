using UnityEngine;
using System.Collections;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]
public class Commands : MonoBehaviour {
	public InputField myInput;
	public Text polecenie;
	public GameObject pole;
	public Text Biuro;
	public Text Magazyn;
	public Text Komisariat;
	public Text Mieszkanie;
	public Text Sklep;
	public Text Mieszkanie2;
void Update () {

	
}

public void changeText()
{

		string input = myInput.value;
	/*	if (input == "test" || input == "idz w lewo") {
						polecenie.text = myInput.text.text;
						myInput.value = "";
				}	*/
		if (input == "pokaz dowody") {
						pole.SetActive (true);

			Biuro.text = "";
			Magazyn.text ="";
			Komisariat.text ="";
			Mieszkanie.text ="";
			Sklep.text ="";
			Mieszkanie2.text = "";
			myInput.value = "";	
				} else if (input == "zamknij dowody") {
			pole.SetActive(false);
			Biuro.text = "Biuro";
			Magazyn.text ="Magazyn";
			Komisariat.text ="Komisariat";
			Mieszkanie.text ="Kowalscy";
			Sklep.text ="Sklep";
			Mieszkanie2.text = "Nowak";
			myInput.value = "";
				}
}
}