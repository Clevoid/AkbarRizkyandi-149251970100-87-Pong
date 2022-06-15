using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class ScoreManager : MonoBehaviour
{
	public int rightScore;
	public int leftScore;
	public int maxScore;
	public Ball_Movement ball;
	public Paddle_Kanan padKanan;
	public Paddle_Kiri padKiri;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void addRightScore(int tambah){
		rightScore += tambah;
		if(rightScore >= maxScore){
			GameOver();
		}
		ball.ResetBall();
		padKanan.resetPaddle();
		padKiri.resetPaddle();
	}
	
	public void addLeftScore(int tambah){
		leftScore += tambah;
		if(leftScore >= maxScore){
			GameOver();
		}
		ball.ResetBall();
		padKanan.resetPaddle();
		padKiri.resetPaddle();
	}
	
	public void GameOver(){
		SceneManager.LoadScene("MainMenu"); 
	}
}
