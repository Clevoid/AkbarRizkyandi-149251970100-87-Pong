using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleSpeedUPManager : MonoBehaviour
{
	public int maxPaddleSpeedUPAmount;
	public List<GameObject> paddleSpeedUPList;
	public List<GameObject> paddleSpeedUPTemplateList;
	
	public Transform spawnArea;
	public Vector2 paddleSpeedUPAreaMin;
	public Vector2 paddleSpeedUPAreaMax;
	
	public int spawnInterval;
	private float timer;
	
	public bool isRight;
	
	private void Start(){
		paddleSpeedUPList= new List<GameObject>();
		timer = 0;
	}
	
	private void Update(){
		timer += Time.deltaTime;
		
		//Debug.Log("waktu : " + timer);
		if(timer > spawnInterval){
			GenerateRandomPaddleSpeedUP();
			timer -= spawnInterval;
		}
	}
	
	public void GenerateRandomPaddleSpeedUP(){
		GenerateRandomPaddleSpeedUP(new Vector2(Random.Range(paddleSpeedUPAreaMin.x, paddleSpeedUPAreaMax.x), Random.Range(paddleSpeedUPAreaMin.y, paddleSpeedUPAreaMax.y)));
		//Debug.Log(Random.Range(powerUPAreaMin.x, powerUPAreaMax.x) + " and " + Random.Range(powerUPAreaMin.y, powerUPAreaMax.y));
		//Debug.Log(Random.Range(0, powerUPTemplateList.Count));
	}
	
	public void GenerateRandomPaddleSpeedUP(Vector2 position){
		if(paddleSpeedUPList.Count >= maxPaddleSpeedUPAmount){
			removePaddleSpeedUP(paddleSpeedUPList[0]);
			return;
		}
		
		if(position.x < paddleSpeedUPAreaMin.x ||
			position.x > paddleSpeedUPAreaMax.x ||
			position.y < paddleSpeedUPAreaMin.y ||
			position.y > paddleSpeedUPAreaMax.y){
				return;
			}
		
		int randomIndex = Random.Range(0, paddleSpeedUPTemplateList.Count);
		
		GameObject paddleSpeedUp = Instantiate(paddleSpeedUPTemplateList[randomIndex], new Vector3(position.x, position.y, paddleSpeedUPTemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea);
		paddleSpeedUp.SetActive(true);
		
		paddleSpeedUPList.Add(paddleSpeedUp);
	}
	
	public void removePaddleSpeedUP(GameObject paddleSpeedUP){
			paddleSpeedUPList.Remove(paddleSpeedUP);
			Destroy(paddleSpeedUP);
	}		
	
	public void removeAllpaddleSpeedUP(){
		while(paddleSpeedUPList.Count > 0){
			removePaddleSpeedUP(paddleSpeedUPList[0]);
		}
	}
}
