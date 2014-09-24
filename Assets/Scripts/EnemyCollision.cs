using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 20);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
		GameObject go = collision.gameObject;

		if (go.name == "Ship" || go.name == "Shield(Clone)"|| go.name == "Ship(Clone)") {
			Destroy(go);
			Destroy(gameObject);
		}
		else if (collision.gameObject.name.Contains("Enemy")){
			Physics2D.IgnoreCollision(collider2D, collision.collider);
		}
	}
}
