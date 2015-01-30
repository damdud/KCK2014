using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Story1 : MonoBehaviour {

	public void HistoryOne(){
		PlayerPrefs.SetInt("Story Choose", 1);
		PlayerPrefs.Save ();
		Debug.Log (PlayerPrefs.GetInt ("Story Choose"));
		 
	}
}
