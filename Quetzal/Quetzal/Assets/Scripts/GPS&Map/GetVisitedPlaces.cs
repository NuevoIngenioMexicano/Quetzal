using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GetVisitedPlaces : MonoBehaviour {

	[Tooltip("The list goes: Bellas artes, República de Perú, Zócalo, Templo mayor")]
	public List<GameObject> indicators;

	public void GetPlaces(){
		// Get places from interface
		// if first is unlocked
		indicators[0].SetActive(true);
		// If second is unlocked
		indicators[0].SetActive(true);
		// If third
		indicators[0].SetActive(true);
		// If fourth
		indicators[0].SetActive(true);
	}
}
