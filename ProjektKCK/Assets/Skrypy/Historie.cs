using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Historie : MonoBehaviour {
	public Text Historia;
	bool Przelacznik = false;
	// Use this for initialization
	void Start () {
		Debug.Log (PlayerPrefs.GetInt("Story Choose"));
	if (PlayerPrefs.GetInt ("Story Choose") == 1 && PlayerPrefs.GetInt("Przelacznik")==0) {
						PlayerPrefs.SetInt("Przelacznik",1);
						Historia.text = "Drogi Inspektorze potrzebujemy Twojej pomocy!\nPani Kowalskiej skradziono bardzo drogi srebrny łańcuszek wysadzany brylantami wart\nmiliard dolarów! Policja nie była w stanie znaleźć żadnych konkretnych tropów, które\nby mogły nas poprowadzić w kierunku złodzieja. Dlatego jesteś naszą ostatnią nadzieją.\nPomożesz nam?";	
						StartCoroutine("Timer");
						
				} else if (PlayerPrefs.GetInt ("Story Choose") == 2 && PlayerPrefs.GetInt("Przelacznik")==0) {
						PlayerPrefs.SetInt("Przelacznik",1);
						Historia.text = "Inspektorze stało się coś strasznego! Mój kotek Pusia zaginął! Ktos ją porwał! Znalazłam na\nstole w salonie kartkę na której było napisane : zapłać okup albo Pusia zginie.\nProszę, pomóż mi ją odnaleźć!";
						StartCoroutine("Timer");
					
				} else if (PlayerPrefs.GetInt ("Story Choose") == 3 && PlayerPrefs.GetInt("Przelacznik")==0) {
						PlayerPrefs.SetInt("Przelacznik",1);
						Historia.text = "Inspektorze Java stała się straszna tragedia. Moja matka, Amelia Skwarek została\nzamordowana w swoim mieszkaniu, kompletnie nie wiem co mam począć. Przecież ona\nnie miała żadnych wrogów a z mieszkania nic nie zginęło. Błagam Cię o pomoc. Musisz się\ndowiedzieć kto zamordował moją matkę. Tylko Ty możesz to zrobić.";
						StartCoroutine("Timer");
					

				}
		PlayerPrefs.Save ();

	}
	IEnumerator Timer(){
		yield return new WaitForSeconds(15f);
		Historia.text = "";
		}
	

}
