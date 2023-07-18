using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGeneration : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        //cameraAspect = Camera.main.aspect;
        //string[,] a = GenerateData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*string[,] GenerateData() {
        
        int height = 2 * 7;
        int width =  2 * (height * (int) Math.Ceiling(cameraAspect) + 4);
        string[,] array = new string[height,width];

        for (int y = 0; y < height; y++) {
            for (int x = 0; x < width; x++) {
                array[y, x] = "w";
            }
        }
        Debug.Log("width: " + width + "; height: " + height + "; aspect: " + cameraAspect);
        return array;
    }*/
}
