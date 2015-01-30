using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Story2 : MonoBehaviour {


	public void HistoryTwo(){
		PlayerPrefs.SetInt("Story Choose", 2);
		PlayerPrefs.Save ();
		Debug.Log (PlayerPrefs.GetInt ("Story Choose"));
	}
}
