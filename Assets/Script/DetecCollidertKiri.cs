using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetecCollidertKiri : MonoBehaviour
{
	public Collider2D ball;
	public LengthUPManager lengthUPManager;
	public PaddleSpeedUPManager PadSpeedUPManager;
	
    private void OnTriggerEnter2D(Collider2D collision){
		if(collision == ball){
			//Debug.Log("Pad Kiri OK");
			lengthUPManager.isRight = false;
			PadSpeedUPManager.isRight = false;
		}
	}
}
