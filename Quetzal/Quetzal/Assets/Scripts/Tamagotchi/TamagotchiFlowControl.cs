using UnityEngine;
using System.Collections;

public class TamagotchiFlowControl : MonoBehaviour {

	public GameObject feedPanel;
	public GameObject healthPanel;
	public GameObject storePanel;
	public GameObject skinsPanel;
	public GameObject funPanel;

	[Header("Info bars")]
	public GameObject hungerBar;
	public GameObject funBar;
	public GameObject healthBar;


	public void ShowFeedPanel(){
		feedPanel.SetActive (true);
	}

	public void HideFeedPanel(){
		feedPanel.SetActive (false);
	}

	public void ShowHealthPanel(){
		healthPanel.SetActive (true);
	}

	public void HideHealthPanel(){
		healthPanel.SetActive (false);
	}

	public void ShowStorePanel(){
		storePanel.SetActive (true);
	}

	public void HideStorePanel(){
		storePanel.SetActive (false);
	}

	public void ShowSkinsPanel(){
		skinsPanel.SetActive (true);
	}

	public void HideSkinsPanel(){
		skinsPanel.SetActive (false);
	}

	public void ShowFunPanel(){
		// Show dialogue panel
		funPanel.SetActive(true);
		// Hide bars
		hungerBar.SetActive(false);
		funBar.SetActive (false);
		healthBar.SetActive (false);
	}

	public void HideFunPanel(){
		// Hide dialogue panel
		funPanel.SetActive(false);
		// Show bars
		hungerBar.SetActive(true);
		funBar.SetActive (true);
		healthBar.SetActive (true);
	}

	public void CloseTamagotchi(){
		//Change scene
	}

}
