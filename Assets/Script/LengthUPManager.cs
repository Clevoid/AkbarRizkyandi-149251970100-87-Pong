using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LengthUPManager : MonoBehaviour
{
	public int maxLengthUPAmount;
	public List<GameObject> lengthUPList;
	public List<GameObject> lengthUPTemplateList;
	
	public Transform spawnArea;
	public Vector2 lengthUPAreaMin;
	public Vector2 lengthUPAreaMax;
	
	public int spawnInterval;
	private float timer;
	
	public bool isRight;
	
	private void Start(){
		lengthUPList= new List<GameObject>();
		timer = 0;
	}
	
	private void Update(){
		timer += Time.deltaTime;
		
		//Debug.Log("waktu : " + timer);
		if(timer > spawnInterval){
			GenerateRandomLengthUP();
			timer -= spawnInterval;
		}
	}
	
	public void GenerateRandomLengthUP(){
		GenerateRandomLengthUP(new Vector2(Random.Range(lengthUPAreaMin.x, lengthUPAreaMax.x), Random.Range(lengthUPAreaMin.y, lengthUPAreaMax.y)));
		//Debug.Log(Random.Range(powerUPAreaMin.x, powerUPAreaMax.x) + " and " + Random.Range(powerUPAreaMin.y, powerUPAreaMax.y));
		//Debug.Log(Random.Range(0, powerUPTemplateList.Count));
	}
	
	public void GenerateRandomLengthUP(Vector2 position){
		if(lengthUPList.Count >= maxLengthUPAmount){
			removeLengthUP(lengthUPList[0]);
			return;
		}
		
		if(position.x < lengthUPAreaMin.x ||
			position.x > lengthUPAreaMax.x ||
			position.y < lengthUPAreaMin.y ||
			position.y > lengthUPAreaMax.y){
				return;
			}
		
		int randomIndex = Random.Range(0, lengthUPTemplateList.Count);
		
		GameObject lengthUp = Instantiate(lengthUPTemplateList[randomIndex], new Vector3(position.x, position.y, lengthUPTemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea);
		lengthUp.SetActive(true);
		
		lengthUPList.Add(lengthUp);
	}
	
	public void removeLengthUP(GameObject lengthUP){
			lengthUPList.Remove(lengthUP);
			Destroy(lengthUP);
	}		
	
	public void removeAllLengthUP(){
		while(lengthUPList.Count > 0){
			removeLengthUP(lengthUPList[0]);
		}
	}
}