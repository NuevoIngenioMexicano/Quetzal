using UnityEngine;
using System.Collections;

public class PlusPointsTextAnimStop : MonoBehaviour {



	void OnEnable(){
		StartCoroutine ("StopAnimation");
	}
	
	IEnumerator StopAnimation(){
		yield return new WaitForSeconds (1f);
		this.gameObject.SetActive (false);
	}
}
