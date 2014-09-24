using UnityEngine;
using System.Collections;

public class ShipScript : MonoBehaviour {
	public Transform shipPrefab;

	float timeCounter=0;

	float speed;
	float width;
	float heigth;
	float direction;

	// Use this for initialization
	void Start () {
		speed = 3; 
		width = 4; 
		heigth = width;
	}

	// Update is called once per frame
	void Update () {
		float input = Input.GetAxis ("Horizontal");

		if (input>0) {
			timeCounter = timeCounter + Time.deltaTime * speed * Mathf.Abs(input);
		}
		if (input<0) {
			timeCounter = timeCounter - Time.deltaTime * speed * Mathf.Abs(input);
		}

		float x = Mathf.Cos (timeCounter)*width;
		float y = Mathf.Sin (timeCounter)*heigth;
		rigidbody2D.position =  new Vector2 (x, y);
		rigidbody2D.MoveRotation(Mathf.Atan2(y , x) * Mathf.Rad2Deg + 90);

		bool shoot = Input.GetButtonDown("Fire1");

		if (shoot)
		{
			WeaponScript weapon = GetComponent<WeaponScript>();
			if (weapon != null)
			{
				// false because the player is not an enemy
				weapon.Attack(false);
			}
		}

		bool shield = Input.GetButtonDown ("Fire2");
		if(shield){
			DeployShield deployShield = GetComponent<DeployShield>();
			if (deployShield != null){
				deployShield.Shield();
			}
		}
		if (transform.childCount > 0) {
						collider2D.enabled = false;
				} else
						collider2D.enabled = true;
	}
	void OnDestroy() {
		StageManager.lives -= 1;
	}}
