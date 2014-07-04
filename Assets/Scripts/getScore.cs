using UnityEngine;
using System.Collections;

public class getScore : MonoBehaviour {

public TextMesh timer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	timer.text = PlayerPrefs.GetFloat("Player Score").ToString("F2");
	}
}
