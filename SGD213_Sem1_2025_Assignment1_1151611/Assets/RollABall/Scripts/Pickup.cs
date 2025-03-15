using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
	private Score score;

    private void Start()
    {
		// Finds the objects that will be used to calculate score
		score = FindObjectOfType<Score>();
    }

    void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))

		{
			gameObject.SetActive(false);
			score.UpdateScoreboard();
		}
	}
}
