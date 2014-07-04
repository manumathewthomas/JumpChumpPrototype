using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

	public TextMesh timer;
	public float timerNum =0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	timerNum += Time.deltaTime;
	timer.text = timerNum.ToString("F2");
	PlayerPrefs.SetFloat("Player Score", timerNum);
	}
}
