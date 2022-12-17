using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {
    public GameObject leafPrefab;
	public GameObject poisonPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Use this for initialization
    void Start () {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(leafWave());
		StartCoroutine(poisonWave());
    }
    private void spawnEnemy(){
        GameObject a = Instantiate(leafPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.y*-1, Random.Range(-screenBounds.y, screenBounds.y));
    }
    IEnumerator leafWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
	
	private void spawnPoison(){
        GameObject p = Instantiate(poisonPrefab) as GameObject;
        p.transform.position = new Vector2(screenBounds.y*-1, Random.Range(-screenBounds.y, screenBounds.y));
    }

	IEnumerator poisonWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnPoison();
        }
    }
}