using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Story3 : MonoBehaviour {


	public void HistoryThree(){
		PlayerPrefs.SetInt("Story Choose", 3);
		PlayerPrefs.Save ();
		Debug.Log (PlayerPrefs.GetInt ("Story Choose"));
	}
}
