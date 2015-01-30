using UnityEngine;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

//using System.Dynamic;
public class mapaBiblioteki : MonoBehaviour {
	public string[] chodzenie ;
	public string[] polecenie ;
	public string[] spojniki ;
	public Transform[] miejsca ;
	public string[] laczniki = {"i","oraz",""};
	float moveSpeed = 30.0f;
	float rotateSpeed = 1.0f;

	string[] zdanie;
	string[] tempZdanie2 = {"",""};
	string[] tempZdanie3 = {"","",""};
	public InputField myInput;
	string inputValue;
	//	int dlugosc = 0;
	//projekt, dokumentacja na githubie( wiki), kod, przykłady działania, jakieś ciekawostki    
	int zmienna;
	string[] zdanieDoPodzialu;
	string[] zdaniePoPodziale;
	string poPodziale;
	bool zmiennaBool;
	float dystans;
	int randomNumber;

	bool przelacznik = false;
	bool zmiennaBool2 = true;

	public GameObject pole;
	public GameObject Texty;

	public bool[] miejscaBool;

	float timer ;
	int k;
	int u;
	public Text SKowalski;
	public Text SKowalska;
	public Text SLech;
	public Text SSzymanski;
	public Text SMalinowska;
	public Text SNowak;
	public GameObject textyStat;
	static bool boolBiuro;
	static bool boolMagazyn;
	static bool boolSklep;
	static bool boolKomisariat;
	static bool boolKowalscy;
	static bool boolNowak;
	public Text storyTxt;
	/*void sprawdzanie(string[] poprzednie,string[]reszta){
                        if (reszta.Length == 0)
                                                        return 1;
                        else    
                                        tablica[] = reszta[];
                                return  sprawdzanie (tablica[],reszta[])
                        }*/
	public void Start(){


	}

	public void Pobierz()
		
	{
		
		inputValue = myInput.text;
		myInput.text = "";
		//      Debug.Log (inputValue);
	}

	public void randomBoolean ()
	{
		if (zmiennaBool2) {
			if (UnityEngine.Random.value >= 0.5) {
				zmiennaBool = true;
			} else
				zmiennaBool = false;
		}
	}

	public void Update(){

		SKowalska.text = "Kowalska: " + PlayerPrefs.GetInt ("Kowalska");
		SKowalski.text = "Kowalski: " + PlayerPrefs.GetInt ("Kowalski");
		SLech.text = "Lech: " + PlayerPrefs.GetInt ("Lech");
		SSzymanski.text = "Szymanski: " + PlayerPrefs.GetInt ("Szymanski");
		SMalinowska.text = "Malinowska: " + PlayerPrefs.GetInt ("Malinowska");
		SNowak.text = "Nowak: " + PlayerPrefs.GetInt ("Nowak");
		Debug.Log (dystans);
		if (przelacznik) {
			dystans = Vector3.Distance (gameObject.transform.position, miejsca [k].position);
			if (dystans >= 50) {

				switch(zdanie[2]){
					case "Nowakow":
						if(PlayerPrefs.GetInt("Nowaki")==0){
							gameObject.transform.rotation = Quaternion.Slerp (gameObject.transform.rotation, Quaternion.LookRotation (gameObject.transform.position - miejsca [k].position), rotateSpeed * Time.deltaTime);
							gameObject.transform.position += -gameObject.transform.forward * moveSpeed * Time.deltaTime;
							if(dystans >=49 && dystans <=51)
							{
								PlayerPrefs.SetInt("Nowaki",1);
								PlayerPrefs.Save();
								Application.LoadLevel("mieszkanie");
							}
						}
						else storyTxt.text = "Juz tu bylem. Nie ma czego juz tu szukac.";
						break;

					case "komisariatu":
						if(PlayerPrefs.GetInt("Komisariat")==0){
							gameObject.transform.rotation = Quaternion.Slerp (gameObject.transform.rotation, Quaternion.LookRotation (gameObject.transform.position - miejsca [k].position), rotateSpeed * Time.deltaTime);
							gameObject.transform.position += -gameObject.transform.forward * moveSpeed * Time.deltaTime;
							if(dystans >=49 && dystans <=51)
							{
								PlayerPrefs.SetInt("Komisariat",1);
								PlayerPrefs.Save();
								Application.LoadLevel("komisariat");
							}
						}
						else storyTxt.text = "Juz tu bylem. Nie ma czego juz tu szukac.";
						break;

					case "biura":
						if(PlayerPrefs.GetInt("Biuro")==0){
							gameObject.transform.rotation = Quaternion.Slerp (gameObject.transform.rotation, Quaternion.LookRotation (gameObject.transform.position - miejsca [k].position), rotateSpeed * Time.deltaTime);
							gameObject.transform.position += -gameObject.transform.forward * moveSpeed * Time.deltaTime;
							if(dystans >=49 && dystans <=51)
							{
								PlayerPrefs.SetInt("Biuro",1);
								PlayerPrefs.Save();
								Application.LoadLevel("Biuro");
							}
						}
						else storyTxt.text = "Juz tu bylem. Nie ma czego juz tu szukac.";
						break;

					case "Kowalskich":
						if(PlayerPrefs.GetInt("Kowale")==0){
							gameObject.transform.rotation = Quaternion.Slerp (gameObject.transform.rotation, Quaternion.LookRotation (gameObject.transform.position - miejsca [k].position), rotateSpeed * Time.deltaTime);
							gameObject.transform.position += -gameObject.transform.forward * moveSpeed * Time.deltaTime;
							if(dystans >=49 && dystans <=51)
							{
								PlayerPrefs.SetInt("Kowale",1);
								PlayerPrefs.Save();
								Application.LoadLevel("mieszkanie2");
							}
						}
						else storyTxt.text = "Juz tu bylem. Nie ma czego juz tu szukac.";
						break;
					
					case "magazynu":
						if(PlayerPrefs.GetInt("Magazyn")==0){
							gameObject.transform.rotation = Quaternion.Slerp (gameObject.transform.rotation, Quaternion.LookRotation (gameObject.transform.position - miejsca [k].position), rotateSpeed * Time.deltaTime);
							gameObject.transform.position += -gameObject.transform.forward * moveSpeed * Time.deltaTime;
							if(dystans >=49 && dystans <=51)
							{
								PlayerPrefs.SetInt("Magazyn",1);
								PlayerPrefs.Save();
								Application.LoadLevel("magazyn");
							}
						}
						else storyTxt.text = "Juz tu bylem. Nie ma czego juz tu szukac.";
						break;

					case "sklepu":
						if(PlayerPrefs.GetInt("Sklep")==0){
							gameObject.transform.rotation = Quaternion.Slerp (gameObject.transform.rotation, Quaternion.LookRotation (gameObject.transform.position - miejsca [k].position), rotateSpeed * Time.deltaTime);
							gameObject.transform.position += -gameObject.transform.forward * moveSpeed * Time.deltaTime;
							if(dystans >=49 && dystans <=51)
							{
								PlayerPrefs.SetInt("Sklep",1);
								PlayerPrefs.Save();
								Application.LoadLevel("sklep");
							}
						}
						else storyTxt.text = "Juz tu bylem. Nie ma czego juz tu szukac.";
						break;

					}
				

			}			
		}
		

	}

	public int ilel(string[] zdanko){
		
		int a = 0;
		for (int i = 0; i < zdanko.Length; i++) {

			for (int ja = 0; ja < laczniki.Length; ja++) {
				if (zdanko [i] == laczniki [ja]) {
					a++;
					
				}
				
			}
		}
		return a;
	}
	



	public void Porownaj() {
		
		//Array.Clear (tempZdanie, 2, tempZdanie.Length - 2);
		zdanie = inputValue.Split (" " [0]);
		//tempZdanie ;
		//	Array.Clear (tempZdanie, 2, tempZdanie.Length - 3);
		if (zdanie.Length == 2) {
			dlugoscDwa (zdanie);
		}
		if (zdanie.Length == 3) {
			dlugoscTrzy (zdanie);
		}
		if (zdanie.Length >= 5) {

			
			int start = 0;
			int i;
			int s = 0;
			int c = 0;
			int stoper = 0;
			int straznik = ilel(zdanie);
			//	int bagno = zdanie.Length;
			//	int bagno2 =0;
			
			
			
			for(int x=0;x <= straznik;x++){
				int ii = start;
				while (s == 0) {
					for (i = ii; i < zdanie.Length; i++) {
						
						for (int ja = 0; ja < laczniki.Length; ja++) {
							if (zdanie [i] == laczniki [ja]) {
								
								if(stoper==0){
									start = i + 1;
								}
								s=1;
								stoper = 1;
								
							}
							
						}
						
						
						
						if (stoper !=1) {
							
							if(c < 2){	
								tempZdanie2 [c] = zdanie [i];
							}
							if(c < 3){	
								tempZdanie3 [c] = zdanie [i];
							}
							if(c==2){
								s =1;
								
							}
						}if(s!=1){
							c++;
						}
						
					}
				}
				if(tempZdanie3[1] == tempZdanie3[2]){
					c=1;
				}
				
				//	Debug.Log (c);
				if (c == 1 ) {
					dlugoscDwa (tempZdanie2);
					s = 0;
					c = 0;
					stoper = 0;
					
					poPodziale = String.Join(" ", tempZdanie2);
					//						Debug.Log (poPodziale);
					
					Array.Clear (tempZdanie2, 0, tempZdanie2.Length);
					
				}
				if (c == 2) {
					dlugoscTrzy (tempZdanie3);
					s = 0;
					c = 0;
					stoper = 0;
					poPodziale = String.Join(" ", tempZdanie3);
					//							Debug.Log (poPodziale);
					
					
				}

			}
			
		}
		
	}

	public void dlugoscDwa(string[] zdanie){
		if (zdanie.Length == 2) {
			for (int i = 0; i <4; i++) {
				if (zdanie [0] == chodzenie [i]) {
					Debug.Log ("Czasownik to: " + chodzenie [i]);
				} else if (zdanie [0] == polecenie [i]) {
					Debug.Log ("Polecenie to: " + polecenie [i]);
					if(zdanie[0] == "pokaz" && zdanie[1] == "dowody"){

						//Debug.Log (zdanie[0] + " dowody udalo sie");
						textyStat.SetActive(true);
						Texty.SetActive(false);
						pole.SetActive(true);
						myInput.text = "";

					}
					else if(zdanie[0] == "zamknij" && zdanie[1] =="dowody"){
							Texty.SetActive(true);
						textyStat.SetActive(false);
						pole.SetActive(false);
						myInput.text = "";
					}
				}
				else if (zdanie [0] != chodzenie [i] && zdanie [0] != polecenie [i])
					Debug.Log (zdanie [0] + " to nie czasownik");
				
			}
		}
	}
	public void dlugoscTrzy(string[] zdanie){
		if (zdanie.Length == 3) {
			for (int i = 0; i <4; i++) {
				if (zdanie [0] == chodzenie [i]) {
					//Debug.Log ("Czasownik to: " + chodzenie [i]);
					for(int j=0;j<4;j++){
						if(zdanie[1] == spojniki[j])
						{
							Debug.Log ("Spojnik to: " + spojniki[j]);
						}

						for(int p=0;p<miejsca.Length;p++)
						{

							if(zdanie[2] == miejsca[p].name)
							{


								przelacznik=true;	
								k = p;



							}
						}
					}
				} else if (zdanie [0] == polecenie [i]) {
					Debug.Log ("Polecenie to: " + polecenie [i]);
					for(int j=0;j<4;j++){
						if(zdanie[1] == spojniki[j])
						{
							Debug.Log ("Spojnik to: " + spojniki[j]);
						}
					}
				}
				else if(zdanie[0]=="wyjdz" && zdanie[2] == "budynku")
				{
					for(int p=0;p<miejsca.Length;p++)
						if(zdanie[2] == miejsca[p].name)
					{
						przelacznik = true;
						k=p;
					}
				}

				else if (zdanie [0] != chodzenie [i] && zdanie [0] != polecenie [i])
					Debug.Log (zdanie [0] + " to nie czasownik");
				
			}

		}
	}
	void OnApplicationQuit(){
		PlayerPrefs.SetInt("Kowalski",0);
		PlayerPrefs.SetInt("Kowalska",0);
		PlayerPrefs.SetInt("Nowak",0);
		PlayerPrefs.SetInt("Lech",0);
		PlayerPrefs.SetInt("Szymanski",0);
		PlayerPrefs.SetInt("Malinowska",0);
		PlayerPrefs.SetInt("Nowaki",0);
		PlayerPrefs.SetInt("Komisariat",0);
		PlayerPrefs.SetInt("Biuro",0);
		PlayerPrefs.SetInt("Kowale",0);
		PlayerPrefs.SetInt("Magazyn",0);
		PlayerPrefs.SetInt("Sklep",0);
		PlayerPrefs.SetInt("Przelacznik",0);
		PlayerPrefs.Save ();
	}
}