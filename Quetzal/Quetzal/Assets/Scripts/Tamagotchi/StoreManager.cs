using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StoreManager : MonoBehaviour {

	public GameObject storePanel;
	public GameObject plusPointsTxt;
	public Text currentCoinsTxt;

	void Awake(){
		CreateItems ();
	}

	void OnEnable(){
		currentCoinsTxt.text = PlayerPrefs.GetString ("Coins");
	}
	
	void CreateItems(){
		if (!PlayerPrefs.HasKey ("Skin1")) {
			PlayerPrefs.SetString ("Skin1", "0");
		}

		if (!PlayerPrefs.HasKey ("Skin2")) {
			PlayerPrefs.SetString ("Skin2", "0");
		}

		if (!PlayerPrefs.HasKey ("Skin3")) {
			PlayerPrefs.SetString ("Skin3", "0");
		}
	}

	public void BuyFood1(){
		//Debug.Log (PlayerPrefs.GetString ("Coins"));
		int test = int.Parse (PlayerPrefs.GetString ("Coins"));
		if(test >= 10){
			int food1 = int.Parse(PlayerPrefs.GetString ("Food1"));
			food1 += 10;
			PlayerPrefs.SetString ("Food1", food1.ToString ());
			plusPointsTxt.GetComponent<Text> ().text = "+" + "10";
			plusPointsTxt.SetActive (true);
			storePanel.SetActive (false);
		}
	}

	public void BuyFood2(){
		if(int.Parse(PlayerPrefs.GetString("Coins")) >= 15){
			int food2 = int.Parse(PlayerPrefs.GetString ("Food2"));
			food2 += 10;
			PlayerPrefs.SetString ("Food2", food2.ToString ());
			plusPointsTxt.GetComponent<Text> ().text = "+" + "10";
			plusPointsTxt.SetActive (true);
			storePanel.SetActive (false);
		}
	}

	public void BuyHealth(){
		if(int.Parse(PlayerPrefs.GetString("Health")) >= 10){
			int health = int.Parse(PlayerPrefs.GetString ("Health"));
			health += 10;
			PlayerPrefs.SetString ("Health", health.ToString ());
			plusPointsTxt.GetComponent<Text> ().text = "+" + "10";
			plusPointsTxt.SetActive (true);
			storePanel.SetActive (false);
		}
	}

	public void BuySkin1(){
		if (PlayerPrefs.GetString ("Skin1") == "0") {
			PlayerPrefs.SetString ("Skin1", "1");
			plusPointsTxt.GetComponent<Text> ().text = "+Skin";
			plusPointsTxt.SetActive (true);
			storePanel.SetActive (false);
		}
	}

	public void BuySkin2(){
		if (PlayerPrefs.GetString ("Skin2") == "0") {
			PlayerPrefs.SetString ("Skin2", "1");
			plusPointsTxt.GetComponent<Text> ().text = "+Skin";
			plusPointsTxt.SetActive (true);
			storePanel.SetActive (false);
		}
	}

	public void BuySkin3(){
		if (PlayerPrefs.GetString ("Skin3") == "0") {
			PlayerPrefs.SetString ("Skin3", "1");
			plusPointsTxt.GetComponent<Text> ().text = "+Skin";
			plusPointsTxt.SetActive (true);
			storePanel.SetActive (false);
		}
	}

}
