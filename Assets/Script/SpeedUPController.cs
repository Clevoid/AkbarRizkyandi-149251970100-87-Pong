using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedUPController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public Collider2D ball;
	public float magnitude;
	public PowerUPManager manager;
	
	private void OnTriggerEnter2D(Collider2D collision){
		if(collision == ball){
			//speed up the ball
			ball.GetComponent<Ball_Movement>().ActivatePUSpeedUP(magnitude);
			manager.RemovePowerUP(gameObject);
		}
	}
}
