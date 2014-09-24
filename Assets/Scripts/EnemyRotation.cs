using UnityEngine;
using System.Collections;

public class EnemyRotation : MonoBehaviour {
	public float angularVelocity;
	private float time;
	public float rotationTime;
	private int direction;
	// Use this for initialization
	void Start () {
		direction = 1;
		time = 0f;
		angularVelocity = 20f;
		rotationTime = 5f;
	}
	
	// Update is called once per frame
	void Update () {
		if (time > rotationTime) {
			direction = -1;
		}
		else if (time < 0) {
			direction = 1;
		}

		time += Time.deltaTime * direction;

		transform.RotateAround(Vector3.zero, Vector3.forward, Time.deltaTime * angularVelocity * direction);
	}
}
