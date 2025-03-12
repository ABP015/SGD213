using UnityEngine;

// Include the namespace required to use Unity UI
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    // Create public variables for player speed, and for the Text UI game objects
    [SerializeField]
    private float horizontalAcceleration;

	private Text scoreText;
	private Text winText;

	// Create private references to the rigidbody component on the player, and the count of pick up objects picked up so far
	private Rigidbody rb;
	private float score;

	// At the start of the game..
	void Start ()	
	{
		rb = GetComponent<Rigidbody>();
		rb.AddForce(200, 0, 200);
		score = 0;
		SetCountText();
		winText.text = "";
	}

	void FixedUpdate ()
	{
		// Set some local float variables equal to the value of our Horizontal and Vertical Inputs
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		// Create a Vector3 variable, and assign X and Z to feature our horizontal and vertical float variables above
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * horizontalAcceleration);
	}

	// Function to count pickup score
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up"))

		{
			other.gameObject.SetActive (false);
			score = score + 1;
			SetCountText ();
		}
	}

	// Function to update UI text
    void SetCountText()
	{
		if (score == 0) return;
		scoreText.text = "Count: " + score.ToString ();
		if (score >= 12) 
		{
			// Set the text value of our 'winText'
			winText.text = "You Win!";
		}
	}
}