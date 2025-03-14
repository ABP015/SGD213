using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    // Create public variables for player speed, and for the Text UI game objects
    [SerializeField]
    private float horizontalAcceleration;

	// Create private references to the rigidbody component on the player, and the count of pick up objects picked up so far
	private Rigidbody rb;
	
	// At the start of the game..
	void Start ()	
	{
		
		rb = GetComponent<Rigidbody>();
		rb.AddForce(200, 0, 200);

		// Stops the cube from rotating
		rb.freezeRotation = true;
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

}