using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu_Schene : MonoBehaviour
{	
// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
    }
	
	public void PlayGame(){
		SceneManager.LoadScene("GamePlay");
	}
	
	public void OpenAuthor() 
    { 
        Debug.Log("Created By AkbarRizkyandi - 149251970100-87"); 
    } 
}
