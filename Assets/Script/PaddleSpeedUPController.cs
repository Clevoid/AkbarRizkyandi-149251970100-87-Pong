using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaddleSpeedUPController : MonoBehaviour
{
	public Collider2D paddleKanan;
	public Collider2D paddleKiri;
	public Collider2D ball;
	public int SpeedUPPaddle;
	public PaddleSpeedUPManager manager;
	
	private void OnTriggerEnter2D(Collider2D collision){
		if(collision == ball){
			if(manager.isRight){
				paddleKanan.GetComponent<Paddle_Kanan>().ActivateSpeedPaddleUP(SpeedUPPaddle);
			}
			else{
				paddleKiri.GetComponent<Paddle_Kiri>().ActivateSpeedPaddleUP(SpeedUPPaddle);
			}
			manager.removePaddleSpeedUP(gameObject);
		}
	}
}