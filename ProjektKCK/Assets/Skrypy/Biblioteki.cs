using UnityEngine;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

//using System.Dynamic;
public class Biblioteki : MonoBehaviour {
	public string[] chodzenie ;
	public string[] polecenie ;
	public string[] spojniki ;
	public Transform[] miejsca ;
	public string[] laczniki = {"i","oraz",""};

	public static int Kowalski;
	public static int Kowalska;
	public static int Nowak;
	public static int Szymanski;
	public static int Lech;
	public static int Malinowska;

	public  Text trueDowod;
	public  Text falseDowod;

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
		SKowalska.text = "Kowalska: " + Kowalska.ToString ();
		SKowalski.text = "Kowalski: " + Kowalski.ToString ();
		SLech.text = "Lech: " + Lech.ToString ();
		SSzymanski.text = "Szymanski: " + Szymanski.ToString ();
		SMalinowska.text = "Malinowska: " + Malinowska.ToString ();
		SNowak.text = "Nowak: " + Nowak.ToString ();
		Debug.Log (dystans);
		if (przelacznik) {
			dystans = Vector3.Distance (gameObject.transform.position, miejsca [k].position);
			if (dystans >= 50 && miejsca[k].transform.gameObject.tag != "Pusty"   ) {
				gameObject.transform.rotation = Quaternion.Slerp (gameObject.transform.rotation, Quaternion.LookRotation (gameObject.transform.position - miejsca [k].position), rotateSpeed * Time.deltaTime);
				gameObject.transform.position += -gameObject.transform.forward * moveSpeed * Time.deltaTime;

				if(dystans >=49 && dystans <=51 && zdanie[2] == "budynku") Application.LoadLevel("mapa");

			}
			if (dystans >= 48 && dystans <= 52 && miejsca [k].transform.gameObject.tag != "Pusty" && zmiennaBool2 && zdanie[2] != "budynku"  )
			{
				trueDowod.text = "Poczekaj chwilę, sprawdzę czy jest tu jakiś dowód.";
				timer += Time.deltaTime;
				
				if(timer>=3.0){
					
					randomBoolean();
					zmiennaBool2 = false;
					if(zmiennaBool)
					{
						trueDowod.text = "Znalazłem dowód. Dopasujmy go do sprawdzy i \nchodzmy szukać dalej. Przestępca\njest wciąż na wolności";
						miejsca[k].transform.gameObject.tag = "Pusty";									
						miejscaBool[k] = true;
						
						
						
						//		Debug.Log (x);
						
					}
					else {
						trueDowod.text = "";
						falseDowod.text = "Nie znalazłem tutaj nic przydatnego.\nChodzmy szukac dalej.";
						miejsca[k].transform.gameObject.tag = "Pusty";
						miejscaBool[k] = true;
						
						
						
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
					else if(zdanie[0] == "dopasuj" && zdanie[1]=="dowod"){
						dopasujDowod();
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
	public void dopasujDowod(){
		Debug.Log ("Witaj dowodzie");
		if (zmiennaBool && dystans >= 48 && dystans <= 52) {
			randomNumber = UnityEngine.Random.Range (0, 5); 
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
		
		Debug.Log ("Kowalska: " + Kowalska);
		Debug.Log ("Szymanski: " + Szymanski);
		Debug.Log ("Kowalski: " + Kowalski);
		Debug.Log ("Nowak: " + Nowak);
		Debug.Log ("Lech: " + Lech);
		Debug.Log ("Malinowska: " + Malinowska);
	}
	
	
	
}