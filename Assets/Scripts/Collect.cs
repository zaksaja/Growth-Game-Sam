using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

	public class Collect : MonoBehaviour
	{
		
		
   	 	int leaf = 0;
        [SerializeField] private Text leafText;
       

    
	private void OnTriggerEnter2D(Collider2D collision)
    	{
       	 if (collision.gameObject.CompareTag("Healthy"))
       	 {
            Destroy(collision.gameObject);
            leaf++;
            leafText.text = "Score: " + leaf;
           
            
       	 } else if (collision.gameObject.CompareTag("Poison"))
         {
	         Destroy(collision.gameObject);
	         leaf--;
	         leafText.text  = "Score: " + leaf;
	         
         }
         
        
   	 }
	
	/*public void Update()
	{
		if (leaf >= 10){
			SceneManager.LoadScene("End");
		}
		
	}
	*/
	

}