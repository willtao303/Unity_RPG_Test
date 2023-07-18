using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraScript : MonoBehaviour
{

    public double cameraAspect;
    public static int height;
    public static int width;

	Vector3 camerapos = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraAspect = Camera.main.aspect;
        height = 7;
        width = (height * (int) Math.Ceiling(cameraAspect) + 4);

    	camerapos.Set(PlayerScript.x, PlayerScript.y, -10.0f);
        transform.position = camerapos;
    }
}
