using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public Vector3 newPos = new Vector3(0f,0f,0f);
	private CharacterController controller;
	private float gravity = -.2f;
	private float sideSpeed = 10f;



	void Start () {
		controller = GetComponent<CharacterController>();
	}

	void Update () {
		newPos.x = Input.GetAxis("Horizontal") * Time.deltaTime * sideSpeed;
		newPos.y = Input.GetAxis("Vertical") * Time.deltaTime * sideSpeed;
		//newPos.z += gravity * Time.deltaTime;
		controller.Move(newPos);
	}
}
