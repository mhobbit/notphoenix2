using UnityEngine;
using System.Collections;

public class DoppelgangerMove : MonoBehaviour {
	public float a;
	public float speed = 4f;
	public float diff = 1;

	private Vector3 target;
	private float timeCounter = 0;
	private float time = 0;

	// Use this for initialization
	void Start () {
		target = GameObject.Find ("Ship(Clone)").transform.position;
	}

	public Vector3 getTarget(){
		return target;
	}
	
	// Update is called once per frame
	void Update () {
		float input = Input.GetAxis ("Horizontal");

		time += Time.deltaTime;
		
		if (input>0) {
			timeCounter = timeCounter + Time.deltaTime * speed * Mathf.Abs(input);
		}
		else if (input<0) {
			timeCounter = timeCounter - Time.deltaTime * speed * Mathf.Abs(input);
		}

		float angle = Vector2.Angle (Vector2.right, target);
		
		float x = Mathf.Cos (timeCounter * diff) * time;
		float y = Mathf.Sin (timeCounter * diff) * time;

		Vector2 circle = new Vector2 (x, y);

		rigidbody2D.MovePosition(circle);

		bool shoot = Input.GetButtonDown("Fire1");
		
		if (shoot)
		{
			WeaponScript weapon = GetComponent<WeaponScript>();
			if (weapon != null)
			{
				// false because the player is not an enemy
				weapon.Attack(true);
			}
		}
	}
}
