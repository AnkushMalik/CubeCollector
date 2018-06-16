using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb;

	public float speed = 5;

	void Start(){
		rb = GetComponent<Rigidbody>();
	}

	void Update() {  // place where our instructions before rendering a frame, are placed
	}

	void FixedUpdate() {  // place where our physics calculations are placed
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3( moveHorizontal, 0.0f, moveVertical );

		rb.AddForce(movement * speed);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Collectibles"))
		{
			other.gameObject.SetActive (false);
		}
	}
}
