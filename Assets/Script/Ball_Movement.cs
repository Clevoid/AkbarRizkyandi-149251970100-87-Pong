using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour
{
	public Vector2 speed;
	private Vector2 speedOld;
	private Rigidbody2D rig;
	public Vector2 resetPosition;
	
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
		rig.velocity = speed;
		speedOld = speed;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + (new Vector3(1f, 0, 0) * Time.deltaTime); 
		//transform.Translate(speed * Time.deltaTime);
    }
	
	public void ResetBall() 
    { 
        transform.position = new Vector2(resetPosition.x, resetPosition.y); 
		rig.velocity = speedOld;
    } 
	
	public void ActivatePUSpeedUP(float magnitude){
		rig.velocity *= magnitude;
	}
}
