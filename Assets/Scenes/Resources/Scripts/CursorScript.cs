using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;

public class CursorScript : MonoBehaviour
{
	public static float x;
	public static float y;
    public static string mode;
    public Sprite selctor;
    public Sprite cursor;
    public Sprite pin;
    public Tilemap solids;
    SpriteRenderer render;
	Vector2 pos = new Vector2();

    // Start is called before the first frame update
    void Start()
    {
        mode = "click";
        render = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
    	pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Cursor.visible == true) {
            Cursor.visible = false;
        }

        /*if (Input.GetKeyDown("m")) {
            if (mode == "click") {
                mode = "select";
                self.GetComponent<SpriteRenderer>().sprite = selctor;
            } else if (mode == "select") {
                mode = "pin";
                self.GetComponent<SpriteRenderer>().sprite = pin;
            } else {
                mode = "click";
                self.GetComponent<SpriteRenderer>().sprite = cursor;
            }
        }*/

        if (Input.GetMouseButtonDown(1)) {
            Vector2Int asdf = Vector2Int.FloorToInt(pos);
            Vector3Int intposition = new Vector3Int(asdf.x, asdf.y, 0);
            TileBase ontile = solids.GetTile(intposition);
            Debug.Log(ontile.ToString());
        }

        if (mode == "click") {
            render.sprite = cursor;
            x = (float)pos.x;
            y = (float)pos.y;
            transform.position = pos;
        }

        /*if (mode == "select") {
            render.sprite = selctor;
            x = (float) Math.Floor(pos.x)+0.5f;
            y = (float) Math.Floor(pos.y)+0.5f;
            pos.Set(x, y);
            transform.position = pos;
        }

        if (mode == "hidden-select") {
            render.enabled = false;
            x = (float) Math.Floor(pos.x)+0.5f;
            y = (float) Math.Floor(pos.y)+0.5f;
            pos = new Vector2(x, y);
            transform.position = pos;
        } else if (mode == "hidden-click") {
            render.enabled = false;
            x = (float)pos.x;
            y = (float)pos.y;
            transform.position = pos;
        } else {
            render.enabled = true;
        }*/
    }
}
