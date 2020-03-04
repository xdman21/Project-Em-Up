using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 2;
	public GameObject playerIdle;
	public GameObject playerMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) && this.transform.position.y < -1f) 
		{
			this.transform.Translate(new Vector3(0,1,1.2f) * Time.deltaTime * speed);
		}
		if(Input.GetKey(KeyCode.A)) 
		{
			this.transform.Translate(Vector3.left * Time.deltaTime * speed);
			playerIdle.transform.rotation = new Quaternion(0,0,0,0);
			playerMove.transform.rotation = new Quaternion(0,0,0,0);
		}
		if(Input.GetKey(KeyCode.S) && this.transform.position.y > -3.0f) 
		{
			this.transform.Translate(new Vector3(0,-1,-1.2f) * Time.deltaTime * speed);
			
		}
		if(Input.GetKey(KeyCode.D)) 
		{
			this.transform.Translate(Vector3.right * Time.deltaTime * speed);
			playerIdle.transform.rotation = new Quaternion(0,180,0,0);
			playerMove.transform.rotation = new Quaternion(0,180,0,0);
		}
		if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
		{
			playerIdle.SetActive(false);
			playerMove.SetActive(true);
		}
		else 
		{
			playerIdle.SetActive(true);
			playerMove.SetActive(false);
		}
    }
}
