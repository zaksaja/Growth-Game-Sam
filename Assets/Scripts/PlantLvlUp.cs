using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantLvlUp : MonoBehaviour
{
    
    //object collision triggers growth anim.

    public GameObject growth;
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        GameObject g = Instantiate(growth) as GameObject;
        g.transform.position = transform.position; 
        Destroy(this.gameObject);
        

    }
    
}
