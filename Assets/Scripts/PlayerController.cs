using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed = 5.0f;
	public float turnSpeed = 1.2f;

	/*
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	*/

	void FixedUpdate() {

		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		if (Input.GetKey(KeyCode.LeftArrow)) {
			this.rigidbody.AddRelativeTorque(-Vector3.up * turnSpeed);
			//this.transform.Rotate(0, x * turnSpeed, 0);
			//transform.localRotation.y += x * turnSpeed;
		} else if (Input.GetKey(KeyCode.RightArrow)) {
			this.rigidbody.AddRelativeTorque(Vector3.up * turnSpeed);
			//this.transform.Rotate(0, x * turnSpeed, 0);
			//transform.localRotation.y += x * turnSpeed;
		}



		this.rigidbody.AddRelativeForce(transform.forward * z * speed);
		//this.rigidbody.rotation.y();

		//this.transform.Rotate(0, x * turnSpeed, 0);
		//this.rigidbody.rotation.


		if (Input.GetKey(KeyCode.UpArrow)) {
			//this.transform.position += transform.forward * speed * Time.deltaTime;
			//transform.localPosition += transform.forward * speed;
			//rigidbody.velocity = transform.forward * speed;
			
		} else if (Input.GetKey(KeyCode.DownArrow)) {
			//this.transform.position -= transform.forward * speed * Time.deltaTime;
			//transform.localPosition -= transform.forward * speed;
			//rigidbody.velocity = - transform.forward * speed;
		}



	}
}
