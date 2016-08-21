using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FeedManager : MonoBehaviour {

	public GameObject feedPanel;
	public Text food1NumberTxt;
	public Text food2NumberTxt;
	public GameObject plusPointsTxt;
	public Image foodBar;
	public float currentFood;
	int food1Number;
	int food2Number;

	void Awake(){
		CreateFood ();
	}

	void Start(){
		StartCoroutine ("ReduceFeed");
	}

	void OnEnable(){
		SetFoodsText ();
	}

	public void GiveFood1(){
		if (food1Number > 0) {
			food1Number--;
			SetFood1 (food1Number);
			plusPointsTxt.GetComponent<Text> ().text = "+" + 10;
			currentFood += 10;
			plusPointsTxt.SetActive (true);
			feedPanel.SetActive (false);
			UpdateFeedBar ();
		}
	}

	public void GiveFood2(){
		if (food2Number > 0) {
			food2Number--;
			SetFood2 (food2Number);
			plusPointsTxt.GetComponent<Text> ().text = "+" + 15;
			currentFood += 15;
			plusPointsTxt.SetActive (true);
			this.gameObject.SetActive (false);
			UpdateFeedBar ();
		}
	}

	void CreateFood(){
		if (!PlayerPrefs.HasKey ("Food1")) {
			PlayerPrefs.SetString ("Food1", "10");
		}

		if (!PlayerPrefs.HasKey ("Food2")) {
			PlayerPrefs.SetString ("Food2", "10");
		}
	}

	void SetFoodsText(){
		food1NumberTxt.text = GetFood1 ().ToString ();
		food1Number = GetFood1 ();
		food2NumberTxt.text = GetFood2 ().ToString ();
		food2Number = GetFood2 ();
	}

	int GetFood1(){
		int food1 = int.Parse(PlayerPrefs.GetString("Food1"));
		return food1;
	}

	int GetFood2(){
		int food2 = int.Parse(PlayerPrefs.GetString("Food2"));
		return food2;
	}

	void SetFood1(int food1){
		PlayerPrefs.SetString ("Food1", food1.ToString ());
	}

	void SetFood2(int food2){
		PlayerPrefs.SetString ("Food2", food2.ToString ());
	}

	void UpdateFeedBar(){
		//foodBar.fillAmount = currentFood/100;
	}


	IEnumerator ReduceFeed(){
		while (true) {
			yield return new WaitForSeconds (60);
			currentFood -= 10;
			UpdateFeedBar ();
		}
	}
}
