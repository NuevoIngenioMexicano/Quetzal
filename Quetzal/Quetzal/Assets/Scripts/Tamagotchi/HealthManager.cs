using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthManager : MonoBehaviour {

	public GameObject healthPanel;
	public Text healthNumberTxt;
	public GameObject plusPointsTxt;
	public Image healthBar;
	public float currentHealth;
	int healthNumber;

	void Awake(){
		CreateHealth ();
	}

	void OnEnable(){
		SetFoodsText ();
	}

	// Use this for initialization
	void Start () {
		StartCoroutine ("ReduceHealth");
	}

	public void GiveHealth(){
		if (healthNumber > 0) {
			healthNumber--;
			SetHealth (healthNumber);
			plusPointsTxt.GetComponent<Text> ().text = "+" + 10;
			currentHealth += 10;
			plusPointsTxt.SetActive (true);
			healthPanel.SetActive (false);
			UpdateHealthBar ();
		}
	}

	void UpdateHealthBar(){
		//healthBar.fillAmount = currentFood/100;
	}

	void SetFoodsText(){
		healthNumberTxt.text = GetHealth ().ToString ();
		healthNumber = GetHealth ();
	}
	
	void CreateHealth(){
		if (!PlayerPrefs.HasKey ("Health")) {
			PlayerPrefs.SetString ("Health", "10");
		}
	}

	int GetHealth(){
		int health = int.Parse(PlayerPrefs.GetString("Health"));
		return health;
	}

	void SetHealth(int health){
		PlayerPrefs.SetString ("Health", health.ToString ());
	}


	IEnumerator ReduceHealth(){
		while (true) {
			yield return new WaitForSeconds (90);
			currentHealth -= 10;
			UpdateHealthBar ();
		}
	}
}
