using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) && this.transform.position.y < -1.592938) 
		{
			this.transform.Translate(new Vector3(0,1,1.2f) * Time.deltaTime * speed);
		}
		if(Input.GetKey(KeyCode.A)) 
		{
			this.transform.Translate(Vector3.left * Time.deltaTime * speed);
		}
		if(Input.GetKey(KeyCode.S) && this.transform.position.y > -2.86f) 
		{
			this.transform.Translate(new Vector3(0,-1,-1.2f) * Time.deltaTime * speed);
		}
		if(Input.GetKey(KeyCode.D)) 
		{
			this.transform.Translate(Vector3.right * Time.deltaTime * speed);
		}
    }
}
