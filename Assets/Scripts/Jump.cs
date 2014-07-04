using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public Transform topCube;
	public Transform bottemCube;
	public bool isJumpingTop = false;
	public bool isJumpingBottem = false;
	public bool isSpawning = false;
	public float minTime = 1.0f;
    public float maxTime = 3.0f;
    public GameObject[] enemies;
	public Vector3 jumpVelocityTop;
	public Vector3 downVelocityTop;
	public Vector3 jumpVelocityBottem;
	public Vector3 downVelocityBottem;
	public Vector3 enemyPosition;

	public GameObject tempEnemy;
	// Use this for initialization
	void Start () {
	Debug.Log("jhb");
	}
	
	// Update is called once per frame
	void Update () {
		
		 foreach( Touch touch in Input.touches ){
            if( touch.phase == TouchPhase.Began )
        		{
        			if(touch.position.y > 360 && isJumpingTop)
        			{
        				
						topCube.rigidbody.AddRelativeForce(jumpVelocityTop*2,ForceMode.VelocityChange);	
						isJumpingTop = false;

        			}
        			else if (touch.position.y < 360 && isJumpingBottem)
        			{
        				bottemCube.rigidbody.AddRelativeForce(jumpVelocityBottem*2,ForceMode.VelocityChange);	
						isJumpingBottem = false;
        			}
        		}
		 }


		
		if(Input.GetKeyDown("up") && isJumpingTop)
		{
			topCube.rigidbody.AddRelativeForce(jumpVelocityTop*2,ForceMode.VelocityChange);	
			isJumpingTop = false;
			Debug.Log("Jumping Top");
		}
		if(Input.GetKeyDown("down") && isJumpingBottem)
		{
			bottemCube.rigidbody.AddRelativeForce(jumpVelocityBottem*2,ForceMode.VelocityChange);	
			isJumpingBottem = false;
			Debug.Log("Jumping Bottem");
		}
		
		
				
		topCube.rigidbody.AddRelativeForce(downVelocityTop,ForceMode.VelocityChange);	
		topCube.rigidbody.AddForce(downVelocityTop *2,ForceMode.VelocityChange);
		bottemCube.rigidbody.AddRelativeForce(downVelocityBottem,ForceMode.VelocityChange);	
		bottemCube.rigidbody.AddForce(downVelocityBottem *2,ForceMode.VelocityChange);
		
		if(! isSpawning)
        {
            isSpawning = true;
            int enemyIndex = Random.Range(0, enemies.Length);
            int enemyPos = Random.Range(0,2);
            
           
            
           
            if(enemyIndex == 0)
            {
            	if(enemyPos == 0)
            	{
            		enemyPosition = new Vector3(159.0f,50,425);
            	
            	}
            	else if (enemyPos == 1)
            	{
            		
            		enemyPosition = new Vector3(1685.0f,-50,426);
            	}
            	             }
            else
            {
            	if(enemyPos == 0)
            	{
            		enemyPosition = new Vector3(159.0f,35,425);
            	}
            	else
            	{
            		enemyPosition = new Vector3(1685.0f,-35,426);
            	}
				 
            }
           
             	StartCoroutine(SpawnObject(enemyIndex, Random.Range(minTime, maxTime)));

         
        }
}

IEnumerator SpawnObject(int index, float seconds)
    {
        Debug.Log ("Waiting for " + seconds + " seconds");

        yield return new WaitForSeconds(seconds);
        tempEnemy = Instantiate(enemies[index],enemyPosition, transform.rotation) as GameObject;
		
       
        isSpawning = false;
    }

IEnumerator SpawnObject2(int index, float seconds)
    {
        Debug.Log ("Waiting for " + seconds + " seconds");

        yield return new WaitForSeconds(seconds);
        tempEnemy = Instantiate(enemies[index],enemyPosition, transform.rotation) as GameObject;
		
       
        isSpawning = false;
    }

	void OnCollisionEnter(Collision col)
	{
		if(col.transform.name == "top")
		{
			isJumpingTop = true;
			Debug.Log("Top touching");
		}
		
		if(col.transform.name == "bottom")
		{
			isJumpingBottem = true;
			Debug.Log("Bottem touching");
		}
	}

}