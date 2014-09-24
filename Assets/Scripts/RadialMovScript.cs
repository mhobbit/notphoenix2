using UnityEngine;
using System.Collections;

public class RadialMovScript : MonoBehaviour {

	public float direction = -1;
	public float speed = 1;

	private Vector2 movement;
	private float step;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		step = speed * Time.deltaTime;
	}

	void FixedUpdate()
	{
		//rigidbody2D.AddForce (movement);

		//rigidbody2D.position = Vector3.MoveTowards (transform.position, Vector2.zero, step);
		rigidbody2D.MovePosition(Vector2.MoveTowards (transform.position, Vector2.zero, step));
		rigidbody2D.MoveRotation(Mathf.Atan2 (transform.position.y, transform.position.x) * Mathf.Rad2Deg + 90);
	}
}
