using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {


	public Vector3 enemyWalkDistance;
	public float enemyWalkDirection = 1.0f;
	public float []enemySpeed; 
	public int index;
	// Use this for initialization
	void Start () {
	index = Random.Range(0,4);
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.z ==425)
			transform.position += new Vector3(enemyWalkDirection * enemySpeed[index] * Time.deltaTime,0.0f,0.0f);
		else
			transform.position += new Vector3(-enemyWalkDirection * enemySpeed[index] * Time.deltaTime,0.0f,0.0f);
			
			
			if(transform.position.x < -1800 || transform.position.x >1800 )
			{
				Destroy(gameObject);
			}
			
			
	}
	
	

}
