using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetecCollidertKanan : MonoBehaviour
{
	public Collider2D ball;
	public LengthUPManager lengthUPManager;
	public PaddleSpeedUPManager PadSpeedUPManager;
	
    private void OnTriggerEnter2D(Collider2D collision){
		if(collision == ball){
			//Debug.Log("Pad Kanan OK");
			lengthUPManager.isRight = true;
			PadSpeedUPManager.isRight = true;
		}
	}
}
