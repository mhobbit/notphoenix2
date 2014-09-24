using UnityEngine;
using System.Collections;

public class StageManager : MonoBehaviour {
	public static int lives = 3;
	public static int score = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.name == "Score") {
			gameObject.guiText.text = "Score: "+score;
		}
		if (gameObject.name == "Lives") {
			gameObject.guiText.text = "Lives >< "+lives;
		}
	}
}
