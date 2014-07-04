using UnityEngine;
using System.Collections;

public class CollisionEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision col)
	{
		if(col.transform.name =="Enemy1(Clone)" || col.transform.name == "Enemy2(Clone)")
		{
			Application.LoadLevel(2);
		}
		
	}
}
