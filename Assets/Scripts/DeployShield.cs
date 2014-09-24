using UnityEngine;
using System.Collections;

public class DeployShield : MonoBehaviour {

	public Transform shieldPrefab;
	public float shieldRate = 1f;
	private float shieldCoolDown;

	// Use this for initialization
	void Start () {
		shieldCoolDown = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (shieldCoolDown > 0)
			shieldCoolDown -= Time.deltaTime;
	}

	public void Shield() {
		if (CanAttack) {
			shieldCoolDown = shieldRate;
			var shieldTransform = Instantiate(shieldPrefab) as Transform;
			shieldTransform.parent = transform;
			shieldTransform.position = transform.position;
			shieldTransform.rotation = transform.rotation;
		}
	}

	public bool CanAttack
	{
		get
		{
			return shieldCoolDown <= 0f;
		}
	}
}
