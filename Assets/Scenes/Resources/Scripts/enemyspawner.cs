using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    public GameObject prefab;
    public GameObject enemyParent;

	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    	if (Input.GetKeyDown("q")) {
    	    var newenemy = Instantiate(prefab, new Vector2(CursorScript.x, CursorScript.y), Quaternion.identity);
            newenemy.transform.parent = enemyParent.transform;
    	}
    }
}
