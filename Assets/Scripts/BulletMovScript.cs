using UnityEngine;
using System.Collections;

public class BulletMovScript : MonoBehaviour {

	public float direction = -1;

	private Vector2 movement;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		movement = direction * Vector2.MoveTowards (transform.position, Vector2.zero, 0);
		if (rigidbody2D.position == Vector2.zero)
			Destroy (gameObject, 0);

	}

	void FixedUpdate()
	{
		rigidbody2D.AddForce (movement);
		rigidbody2D.MoveRotation(Mathf.Atan2 (transform.position.y, transform.position.x) * Mathf.Rad2Deg + 90);
	}
}
