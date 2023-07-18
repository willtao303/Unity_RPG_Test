using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
	float speed = 0.13f;

	public static float x = 0.0f;
    public static float y = 0.0f;
    public static Vector2 pos;

    public bool cangoup = true;
    public bool cangodown = true;
    public bool cangoright = true;
    public bool cangoleft = true;

    // Start is called before the first frame update
    void wStart()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w") & cangoup) {
            if (Input.GetKey("a") & cangoleft) {
                y += speed * 0.7f;
                x -= speed * 0.7f;
            }
            else if (Input.GetKey("d") & cangoright) {
                y += speed * 0.7f;
                x += speed * 0.7f;
            } 
            else {
                y += speed;
            }
        }
    	else if (Input.GetKey("a") & cangoleft) {
            if (Input.GetKey("w") & cangoup) {
                y += speed * 0.7f;
                x -= speed * 0.7f;
            }
            else if (Input.GetKey("s") & cangodown) {
                y -= speed * 0.7f;
                x -= speed * 0.7f;
            } 
            else {
   	    	   x -= speed;
            }
    	}
    	else if (Input.GetKey("s") & cangodown) {
   	    	if (Input.GetKey("a") & cangoleft) {
                y -= speed * 0.7f;
                x -= speed * 0.7f;
            }
            else if (Input.GetKey("d") & cangoright) {
                y -= speed * 0.7f;
                x += speed * 0.7f;
            } 
            else {
               y -= speed;
            }
    	} 
    	else if (Input.GetKey("d") & cangoright) {
   	    	if (Input.GetKey("w") & cangoup) {
                y += speed * 0.7f;
                x += speed * 0.7f;
            }
            else if (Input.GetKey("s") & cangodown) {
                y -= speed * 0.7f;
                x += speed * 0.7f;
            } 
            else {
               x += speed;
            }
    	} 

    	pos.Set(x, y);
    	transform.position = pos;
    }
}
