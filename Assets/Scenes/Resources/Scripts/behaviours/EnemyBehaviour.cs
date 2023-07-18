using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyBehaviour : MonoBehaviour
{
	bool attack = false;

	float speed = 0.05f;
	Vector2 pos = new Vector2();
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    	if (Vector2.Distance(pos, PlayerScript.pos) > 1) {
    		attack = false;
	        pos = Vector2.MoveTowards(pos, PlayerScript.pos, speed);
    	} else {
    		attack = true;
    	}
        transform.position = pos;
    }

    void OnCollisionEnter(Collision collision)
    {
    	//if (collision.gameObject.name == "Player")
    }
}
