using UnityEngine;
using System.Collections;

public class SpiralMovement : MonoBehaviour {
	public float a;
	public float speed;
	private float t;

	// Use this for initialization
	void Start () {
		t = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		t += Time.deltaTime * speed;
		float x = a * t * Mathf.Cos (t);
		float y = a * t * Mathf.Sin (t);

		transform.position = new Vector2 (x, y);
	}
}
