using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class collisiondetection : MonoBehaviour
{

	Tilemap solids;
    // Start is called before the first frame update
    void Start()
    {
        solids = gameObject.GetComponent("solids") as Tilemap;

    }

    // Update is called once per frame
    void Update()
    {
    	
    	TileBase a = solids.GetTile(Vector3Int.FloorToInt(new Vector3(PlayerScript.x, PlayerScript.y, 0)));
    	if (a) {
    		Debug.Log("cool");
    	}
    }
}
