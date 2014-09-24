using UnityEngine;
using System.Collections;

public class EnemyBulletMoveScript : MonoBehaviour {
	public float speed = 1f;

	private Vector3 direction;
	private float step;
	// Use this for initialization
	void Start () {
		direction = GameObject.Find ("Ship(Clone)").transform.position;
		Destroy (gameObject, 10);
	}
	
	// Update is called once per frame
	void Update () {
		step = speed * Time.deltaTime;
	}

	void FixedUpdate () {
		rigidbody2D.MovePosition(Vector2.MoveTowards (transform.position, direction*10, step));
	}
}
