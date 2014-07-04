using UnityEngine;
using System.Collections;

public class button : MonoBehaviour {

	Ray ray;
    RaycastHit hit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	if(Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            // Reset ray with new mouse position
            ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
            if(Physics.Raycast(ray, out hit)) {
                if(hit.transform.name == "Plane") {
                	Application.LoadLevel(3);
                }
                
                 if(hit.transform.name == "Plane_play") {
                	Application.LoadLevel(1);
                }
                
                  if(hit.transform.name == "Play") {
                	Application.LoadLevel(1);
                }
            }
		}
		
		
	 foreach( Touch touch in Input.touches ){
            if( touch.phase == TouchPhase.Began )
        		{
                Ray ray = camera.ScreenPointToRay(new Vector3(touch.position.x, touch.position.y, 0));
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, Mathf.Infinity, 10))
                    {
                    	if(hit.transform.name == "Plane")
                    		Application.LoadLevel(3);
                    }
                     if(hit.transform.name == "Plane_play") {
                	Application.LoadLevel(1);
                }
                
                  if(hit.transform.name == "Play") {
                	Application.LoadLevel(1);
                }
                
                
    	    }
		}
	
	}
}
