using UnityEngine;
using System.Collections;

public class ScaleFromCenter : MonoBehaviour {
	float scale;
	Vector3 scaleVector;
	Vector3 lastposition;

	// Use this for initialization
	void Start () {
		scale = 1;
		lastposition = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		if (!Vector3.Equals(lastposition, transform.position)) {
			//Debug.Log(lastposition);
			scale = Vector3.Magnitude (transform.position)/4;
			scaleVector = new Vector3(scale, scale, 1);
			
			transform.localScale = scaleVector;
			lastposition = transform.position;
		}
	}
}
