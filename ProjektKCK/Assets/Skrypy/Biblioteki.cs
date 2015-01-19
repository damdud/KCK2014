using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
public class Biblioteki : MonoBehaviour {
	public string[] chodzenie ;
	public string[] polecenie ;
	public string[] spojniki ;
	public string[] miejsca ;
	public string[] laczniki ;
	string[] zdanie;
	public InputField myInput;
	string inputValue;
	int dlugosc = 0;
	//projekt, dokumentacja na githubie( wiki), kod, przykłady działania, jakieś ciekawostki	
	int zmienna;
	string[] tempZdanie;
	string[] zdanieDoPodzialu;
	string[] zdaniePoPodziale;
	string[] poPodziale;
	/*void sprawdzanie(string[] poprzednie,string[]reszta){
		if (reszta.Length == 0)
						return 1;
		else 	
				tablica[] = reszta[];
			return	sprawdzanie (tablica[],reszta[])
		}*/
	public void Pobierz()
	
	{

		inputValue = myInput.text;
	//	Debug.Log (inputValue);
	}


	

	public void Porownaj() {
		zdanie = inputValue.Split (" "[0]);
		//Debug.Log (zdanie[0

		if (zdanie.Length == 2) {
			dlugoscDwa();
				}
		if (zdanie.Length == 3) {
			dlugoscTrzy();
				} 
		if (zdanie.Length >= 5) {
			for(int g=0;g<zdanie.Length;g++){
				zdanieDoPodzialu = zdanieDoPodzialu + zdanie[g] + " ";}
				//Debug.Log (zdanieDoPodzialu);

			poPodziale = zdanieDoPodzialu.;
			Debug.Log (poPodziale);
//			for(int u =0 ; u< zdaniePoPodziale.Length;u++)
		//	Debug.Log (zdaniePoPodziale[u]);
		//		zdanieDoPodzialu = "";
		//		Array.Clear(zdanie, 0, zdanie.Length);
		//		Array.Clear(zdaniePoPodziale, 0, zdaniePoPodziale.Length);

			


			/*int a = 0;
			int c = 0;
			for(int b=0;b<zdanie.Length;b++){
				while (zdanie[a] != laczniki[b]) {
					tempZdanie[c] = zdanie[a];
					c++;
					a++;
				}
				
				if (zdanie[a] == laczniki[b]){		
					if(tempZdanie.Length == 2)
						tempDlugoscDwa();
					else if(tempZdanie.Length == 3)
						tempDlugoscTrzy();
					c = 0;
					Array.Clear(tempZdanie, 0, tempZdanie.Length);
					a++;				
				}	
			}
			//http://gyazo.com/59736f329ec48446f95c7a58c024cee9*/
		}



	}
	public void dlugoscDwa(){
		if (zdanie.Length == 2) {
			for (int i = 0; i <4; i++) {
				if (zdanie [0] == chodzenie [i]) {
					Debug.Log ("Czasownik to: " + chodzenie [i]);
				} else if (zdanie [0] == polecenie [i]) {
					Debug.Log ("Polecenie to: " + polecenie [i]);
					if(zdanie[1] == "dowody" && (zdanie[0] == "pokaz" || zdanie[0] == "zamknij")){
						Debug.Log (zdanie[0] + " dowody udalo sie");
					}
				} else if (zdanie [0] != chodzenie [i] && zdanie [0] != polecenie [i])
					Debug.Log (zdanie [0] + " to nie czasownik");
				
			}
		}
	}
	public void dlugoscTrzy(){
		if (zdanie.Length == 3) {
			for (int i = 0; i <4; i++) {
				if (zdanie [0] == chodzenie [i]) {
					Debug.Log ("Czasownik to: " + chodzenie [i]);
					for(int j=0;j<4;j++){
						if(zdanie[1] == spojniki[j])
						{
							Debug.Log ("Spojnik to: " + spojniki[j]);
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
				} else if (zdanie [0] != chodzenie [i] && zdanie [0] != polecenie [i])
					Debug.Log (zdanie [0] + " to nie czasownik");
				
			}
		}
	}



}
