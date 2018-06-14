using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	void Start () {
		offset = transform.position - player.transform.position;
	}
	// LateUpdate is called once per frame after processing all instructions from update
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
