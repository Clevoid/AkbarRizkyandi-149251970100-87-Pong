using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle_Kanan : MonoBehaviour
{
	public int Kecepatan;
	public KeyCode upKey;
	public KeyCode downKey;
	private Rigidbody2D rig;
	
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
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
			return Vector2.up * Kecepatan;
		} 
		else if(Input.GetKey(downKey))
		{ 
			// ke bawah 
			return Vector2.down * Kecepatan;
		} 
		return Vector2.zero;
	}
	
	private void MoveObject(Vector2 movement)
	{
		//transform.Translate(movement * Time.deltaTime);
		//Debug.Log("TEST: " + movement); 
		rig.velocity = movement;
	}
}