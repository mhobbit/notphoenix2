using UnityEngine;
using System.Collections;

public class DoppelgangerMove : MonoBehaviour {
	public float a;
	public float speed = 4f;
	public float diff = 1;

	private Vector3 target;
	private float timeCounter = 0;
	private float time = 0;
	private float angle;

	// Use this for initialization
	void Start () {
		GameObject go = GameObject.Find ("Ship(Clone)");
		target = go.transform.position;
		angle = Random.Range (0, 360);
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

		//float angle = Vector3.Angle (target, Vector2.right);
		
		float x = Mathf.Cos ((timeCounter + angle) * diff) * time;
		float y = Mathf.Sin ((timeCounter + angle) * diff) * time;

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
