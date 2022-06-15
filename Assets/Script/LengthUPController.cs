using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LengthUPController : MonoBehaviour
{
	public Collider2D paddleKanan;
	public Collider2D paddleKiri;
	public Collider2D ball;
	public float panjangPaddle;
	public LengthUPManager manager;
	
	private void OnTriggerEnter2D(Collider2D collision){
		if(collision == ball){
			if(manager.isRight){
				paddleKanan.GetComponent<Paddle_Kanan>().ActivateLengthUP(panjangPaddle);
			}
			else{
				paddleKiri.GetComponent<Paddle_Kiri>().ActivateLengthUP(panjangPaddle);
			}
			manager.removeLengthUP(gameObject);
		}
	}
}
