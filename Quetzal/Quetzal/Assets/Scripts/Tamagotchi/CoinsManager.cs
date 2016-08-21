using UnityEngine;
using System.Collections;

public class CoinsManager : MonoBehaviour {

	public static CoinsManager instance;

	// Use this for initialization
	void Awake () {
		if (instance == null) {
			instance = this;
		}
		CreateCoins ();
	}

	void CreateCoins(){
		if (!PlayerPrefs.HasKey ("Coins")) {
			PlayerPrefs.SetString ("Coins", "100");
		}
	}

	public int GetCoins(){
		int coinsNumber = int.Parse (PlayerPrefs.GetString ("Coins"));
		return coinsNumber;
	}

	public void SetCoins(int coins){
		PlayerPrefs.SetString ("Coins", coins.ToString());
	}
}
