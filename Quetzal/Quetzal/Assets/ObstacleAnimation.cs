using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObstacleAnimation : MonoBehaviour {

	public float minTime;
	public float maxTime;
	public List<GameObject> obstacles;

	void Start(){
		StartCoroutine ("AnimateObstacle");
		StartCoroutine ("AnimateObstacle2");
		StartCoroutine ("AnimateObstacle3");
		StartCoroutine ("AnimateObstacle4");
		StartCoroutine ("AnimateObstacle5");
	}

	IEnumerator AnimateObstacle(){
		while (true) {
			float randomTime = Random.Range (minTime, maxTime + 1);
			yield return new WaitForSeconds (randomTime);
			obstacles[0].gameObject.SetActive (false);
			yield return new WaitForSeconds (randomTime);
			obstacles[0].gameObject.SetActive (true);
		}
	}

	IEnumerator AnimateObstacle2(){
		while (true) {
			float randomTime = Random.Range (minTime, maxTime + 1);
			yield return new WaitForSeconds (randomTime);
			obstacles[1].gameObject.SetActive (false);
			yield return new WaitForSeconds (randomTime);
			obstacles[1].gameObject.SetActive (true);
		}
	}

	IEnumerator AnimateObstacle3(){
		while (true) {
			float randomTime = Random.Range (minTime, maxTime + 1);
			yield return new WaitForSeconds (randomTime);
			obstacles[2].gameObject.SetActive (false);
			yield return new WaitForSeconds (randomTime);
			obstacles[2].gameObject.SetActive (true);
		}
	}

	IEnumerator AnimateObstacle4(){
		while (true) {
			float randomTime = Random.Range (minTime, maxTime + 1);
			yield return new WaitForSeconds (randomTime);
			obstacles[3].gameObject.SetActive (false);
			yield return new WaitForSeconds (randomTime);
			obstacles[3].gameObject.SetActive (true);
		}
	}

	IEnumerator AnimateObstacle5(){
		while (true) {
			float randomTime = Random.Range (minTime, maxTime + 1);
			yield return new WaitForSeconds (randomTime);
			obstacles[4].gameObject.SetActive (false);
			yield return new WaitForSeconds (randomTime);
			obstacles[4].gameObject.SetActive (true);
		}
	}
}
