using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ObstacleCollider : MonoBehaviour {

	public int seconds;
	public int lives;
	public Text secondsTxt;
	public Text remainingLivesTxt;
	Transform originalTransform;
	bool isCounting = true;

	void Start () {
		originalTransform = this.transform;
		StartCoroutine ("ChangeTime");
	}

	void OnTriggerEnter(Collider coll){
		if(coll.CompareTag("Obstacle")){
			if (lives <= 0) {
				Debug.Log ("Perdiste");
				isCounting = false;
				GetComponent<MeshRenderer> ().enabled = false;
			} else {
				GetComponent<MeshRenderer> ().enabled = false;
				StartCoroutine ("ResetLevel");
			}
		}
	}

	void MiniGameOver(){
		// Show mini game over panel

	}

	IEnumerator ResetLevel(){
		yield return new WaitForSeconds (1f);
		GetComponent<MeshRenderer> ().enabled = true;
		remainingLivesTxt.text = "x" + lives--.ToString ();
		this.transform.position = originalTransform.position;
		seconds = 30;
		secondsTxt.text = seconds.ToString ();
	}

	IEnumerator ChangeTime(){
		while (isCounting) {
			yield return new WaitForSeconds (1f);
			secondsTxt.text = seconds--.ToString ();
		}
	}
}
