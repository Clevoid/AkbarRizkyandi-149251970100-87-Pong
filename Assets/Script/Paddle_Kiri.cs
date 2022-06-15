using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle_Kiri : MonoBehaviour
{
	public int Kecepatan;
	public KeyCode upKey;
	public KeyCode downKey;
	private Rigidbody2D rig;
	public Vector2 scaleAwal;
	
	private int KecepatanBaru;
	
	public LengthUPManager LengthManager;
	public PaddleSpeedUPManager PaddleSpeedManager;
	
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
		KecepatanBaru = Kecepatan;
    }

    // Update is called once per frame
    void Update()
    {
		MoveObject(GetInput());
    }
	
	private Vector2 GetInput()
	{
		if (Input.GetKey(upKey))
		{ 
			// ke atas
			return Vector2.up * KecepatanBaru;
		} 
		else if(Input.GetKey(downKey))
		{ 
			// ke bawah 
			return Vector2.down * KecepatanBaru;
		} 
		return Vector2.zero;
	}
	
	private void MoveObject(Vector2 movement)
	{
		rig.velocity = movement;
	}
	
	public void ActivateLengthUP(float panjangY){
		transform.localScale = new Vector2(transform.localScale.x, (transform.localScale.y * panjangY));
	}
	
	public void ActivateSpeedPaddleUP(int speed){
		KecepatanBaru *= speed;
	}
	
	public void resetPaddle(){
		transform.localScale = new Vector2(scaleAwal.x, scaleAwal.y);
		LengthManager.isRight = false;
		PaddleSpeedManager.isRight = false;
		KecepatanBaru = Kecepatan;
	}
}