using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public bool gameHasEnded = false;
	public float restartDelay = 1f;

	public GameObject levelCompleteUI;

	public void CompleteLevel(){
		//Debug.Log ("Completed Level 1");
		levelCompleteUI.SetActive(true);
	}

	// Use this for initialization
	public void EndGame(){
		if (!gameHasEnded) {
			gameHasEnded = true;
			Debug.Log ("Game Over!");
			Invoke ("Restart", restartDelay);
		}
	}

	void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
