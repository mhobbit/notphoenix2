using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {
	public GameObject ship;
	public Vector3 shipPosition = new Vector3(4,0,0);
	public float minTime = 5.0f, maxTime = 1.5f;
	public GameObject[] enemyArray;

	bool spawning = false;
	// Use this for initialization
	void Start () {
	
	}
	IEnumerator SpawnEnemy(int index, float time){
		yield return new WaitForSeconds (time);
		Instantiate (enemyArray [index], transform.position, transform.rotation);
		spawning = false;
	}
	void RespawnShip(){
		Instantiate (ship, shipPosition, Quaternion.identity);
	}

	// Update is called once per frame
	void Update () {
		if (GameObject.Find("Ship(Clone)") == null){
			if(StageManager.lives > 0){
				RespawnShip();
			}
			else if (StageManager.lives == 0){
				//Termina el nivel
				Application.LoadLevel("gameOverMenu");
			}
		}
		if (!spawning) {
			spawning = true;
			int enemyIndex = Random.Range(0, enemyArray.Length);
			StartCoroutine(SpawnEnemy(enemyIndex, Random.Range(minTime, maxTime)));
		}
	}
}
