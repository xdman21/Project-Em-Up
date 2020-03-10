using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
	public GameObject player;
	public float speed;
	
    // Update is called once per frame
    void Update()
    {
		if(Vector3.Distance(this.transform.position, player.transform.position) > 1) 
		{
			Vector3 move = (player.transform.position);
			this.transform.position += ((move - transform.position).normalized * Time.deltaTime * speed);
		}
		else 
		{
			//attack
		}
    }
}
