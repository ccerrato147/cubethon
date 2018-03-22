using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour {

	// Use this for initialization
	void LoadNextLevelFunc(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
}
