using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb;
	private int score;

	public float speed = 5;
	public Text scoreText;
	public Text winText;

	void Start(){
		rb = GetComponent<Rigidbody>();
		score = 0;
		SetScoretext();
		winText.text = "";
	}

	void Update() {  // place where our instructions before rendering a frame, are placed
	}

	void FixedUpdate() {  // place where our physics calculations are placed
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3( moveHorizontal, 0.0f, moveVertical );

		rb.AddForce(movement * speed);
	}

	void SetScoretext(){
		scoreText.text = "Score : " + score.ToString();
		if(score >= 8){
			winText.text = "You Win";
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Collectibles"))
		{
			other.gameObject.SetActive (false);
			score += 1;
			SetScoretext();
		}
	}
}
