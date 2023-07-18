using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildScript : MonoBehaviour
{

	public GameObject Builder;
	public GameObject[] BuildAreas;
	public Sprite[] BuildIndicators;
	int BuildMode = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("b")) {
        	CursorScript.mode = "select";
        	if (Input.GetKeyDown("1")) {
        		BuildMode = 1;
        	} else if (Input.GetKeyDown("2")){
        		BuildMode = 2;
        	} else if (Input.GetKeyDown("3")){
        		BuildMode = 3;
        	} else if (Input.GetKeyDown("4")){
        		BuildMode = 4;
        	}
        } else if (BuildMode == 0) {
            GetComponent<SpriteRenderer>().enabled = false;
        	CursorScript.mode = "click";
        } else {
            GetComponent<SpriteRenderer>().enabled = true;
            CursorScript.mode = "hidden-select";
        }

        if (BuildMode == 1) {
        	transform.position = new Vector2(CursorScript.x, CursorScript.y);
        	GetComponent<SpriteRenderer>().sprite = BuildIndicators[0];
        } else if (BuildMode == 2) {
        	transform.position = new Vector2(CursorScript.x+0.5f, CursorScript.y);
        	GetComponent<SpriteRenderer>().sprite = BuildIndicators[1];
        } else if (BuildMode == 3) {
        	transform.position = new Vector2(CursorScript.x, CursorScript.y-0.5f);
        	GetComponent<SpriteRenderer>().sprite = BuildIndicators[2];
        } else if (BuildMode == 4) {
        	transform.position = new Vector2(CursorScript.x+0.5f, CursorScript.y-0.5f);
        	GetComponent<SpriteRenderer>().sprite = BuildIndicators[3];
        } 


        if (Input.GetKeyDown(KeyCode.Escape)){
        	BuildMode = 0;
        	CursorScript.mode = "click";
        }

        if (Input.GetMouseButtonDown(1)) {
        	switch (BuildMode) {
        		case 1:
        			var newbuild1 = Instantiate(BuildAreas[0], new Vector2(CursorScript.x, CursorScript.y), Quaternion.identity);
    	    		newbuild1.transform.parent = Builder.transform;
    	    		BuildMode = 0;
        			break;
        		case 2:
        			var newbuild2 = Instantiate(BuildAreas[1], new Vector2(CursorScript.x+0.5f, CursorScript.y), Quaternion.identity);
    	    		newbuild2.transform.parent = Builder.transform;
    	    		BuildMode = 0;
        			break;
        		case 3:
        			var newbuild3 = Instantiate(BuildAreas[2], new Vector2(CursorScript.x, CursorScript.y-0.5f), Quaternion.identity);
    	    		newbuild3.transform.parent = Builder.transform;
    	    		BuildMode = 0;
        			break;
        		case 4:
        			var newbuild4 = Instantiate(BuildAreas[3], new Vector2(CursorScript.x+0.5f, CursorScript.y-0.5f), Quaternion.identity);
    	    		newbuild4.transform.parent = Builder.transform;
    	    		BuildMode = 0;
        			break;
        		default:
        			break;
        	}
        }
    }
}
