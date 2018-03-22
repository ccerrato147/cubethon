using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float forwardForce = 2000f;
	public float sidewayForce = 500f;

	// Use this for initialization
	void Start () {
		Debug.Log ("Script started");
		//rb.useGravity = false;
		//rb.AddForce(0,200,500);
	}
	
	// Update is called once per frame
	// FixedUpdate works better for Unity Physics engine
	void FixedUpdate () {
		// Add a forward force
		rb.AddForce(0,0, forwardForce * Time.deltaTime);


		// moving to the right
		if (Input.GetKey ("d")) {
			rb.AddForce (sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		// moving to the left
		if (Input.GetKey ("a")) {
			rb.AddForce (-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		// End game if player falls of the edge
		if (rb.position.y < -1f) {
			FindObjectOfType<GameManager> ().EndGame();
		}
	}
}
