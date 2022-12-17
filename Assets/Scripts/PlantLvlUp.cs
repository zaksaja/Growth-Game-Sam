using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantLvlUp : MonoBehaviour
{
    //public float respawnTime = 1.0f;
	//var growthWave: boolean; 
    //object collision triggers growth anim.
	//int leaves = 0;
	//[SerializeField] Text LeafCounterText;
    public GameObject growth;

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject g = Instantiate(growth) as GameObject;
        g.transform.position = transform.position; 
        //StartCoroutine(growthWave());
		Destroy(g.gameObject);
		//Debug.Log("this works lawl ig?? even tho its excessive");
		
        

    }  
}
