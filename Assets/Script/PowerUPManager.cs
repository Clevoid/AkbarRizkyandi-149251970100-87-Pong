using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUPManager : MonoBehaviour{
	
	public int maxPowerUPAmount;
	public List<GameObject> powerUPList;
	public List<GameObject> powerUPTemplateList;
	
	public Transform spawnArea;
	public Vector2 powerUPAreaMin;
	public Vector2 powerUPAreaMax;
	
	public int spawnInterval;
	private float timer;
	
	private void Start(){
		powerUPList= new List<GameObject>();
		timer = 0;
	}
	
	private void Update(){
		timer += Time.deltaTime;
		
		//Debug.Log("waktu : " + timer);
		if(timer > spawnInterval){
			GenerateRandomPowerUP();
			timer -= spawnInterval;
		}
	}
	
	public void GenerateRandomPowerUP(){
		GenerateRandomPowerUP(new Vector2(Random.Range(powerUPAreaMin.x, powerUPAreaMax.x), Random.Range(powerUPAreaMin.y, powerUPAreaMax.y)));
		//Debug.Log(Random.Range(powerUPAreaMin.x, powerUPAreaMax.x) + " and " + Random.Range(powerUPAreaMin.y, powerUPAreaMax.y));
		//Debug.Log(Random.Range(0, powerUPTemplateList.Count));
	}
	
	public void GenerateRandomPowerUP(Vector2 position){
		if(powerUPList.Count >= maxPowerUPAmount){
			RemovePowerUP(powerUPList[0]);
			return;
		}
		
		if(position.x < powerUPAreaMin.x ||
			position.x > powerUPAreaMax.x ||
			position.y < powerUPAreaMin.y ||
			position.y > powerUPAreaMax.y){
				return;
			}
		
		int randomIndex = Random.Range(0, powerUPTemplateList.Count);
		
		GameObject powerUp = Instantiate(powerUPTemplateList[randomIndex], new Vector3(position.x, position.y, powerUPTemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea);
		powerUp.SetActive(true);
		
		powerUPList.Add(powerUp);
	}
	
	public void RemovePowerUP(GameObject powerUP){
			powerUPList.Remove(powerUP);
			Destroy(powerUP);
	}		
	
	public void RemoveAllPowerUP(){
		while(powerUPList.Count > 0){
			RemovePowerUP(powerUPList[0]);
		}
	}
}
