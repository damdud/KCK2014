using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Commands : MonoBehaviour {
	public InputField myInput;
	public Text polecenie;
	public GameObject pole;
	public GameObject Texty;

public void changeText()
{

		string input = myInput.text;
	/*	if (input == "test" || input == "idz w lewo") {
						polecenie.text = myInput.text.text;
						myInput.value = "";
				}	*/
		if (input == "pokaz dowody") {
	//		Texty.SetActive(false);			
			pole.SetActive(true);
			myInput.text = "";	
				} else if (input == "zamknij dowody") {
		//	Texty.SetActive(true);
			pole.SetActive(false);
			myInput.text = "";

		}
}
}