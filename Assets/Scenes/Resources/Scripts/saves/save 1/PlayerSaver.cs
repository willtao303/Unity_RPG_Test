using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSaver : MonoBehaviour
{

	[System.Serializable]
	public class Player {
		public float location_x = 0.0f;
		public float location_y = 0.0f;
		public int level = 0;
		public int stats_health = 60;
		public int stats_level = 60;
		public int score = 0;
	}

	Player save = new Player();

	public string JsonSave(object obj) {
		using (StreamWriter w = new StreamWriter("Assets/Scenes/Resources/Scripts/saves/save 1/PlayerStats.json"))
        {
        	string json = JsonUtility.ToJson(obj);
            w.WriteLine(json);
            Debug.Log(json);
            return json;
        }
	}

    // Start is called before the first frame update
    void Start()
    {
        using (StreamReader r = new StreamReader("Assets/Scenes/Resources/Scripts/saves/save 1/PlayerStats.json"))
        {
            string json = r.ReadToEnd();
            Debug.Log(json);
            save = JsonUtility.FromJson<Player>(json);
        }

        PlayerScript.y = save.location_y;
        PlayerScript.x = save.location_x;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift)) {
        	save.location_y = PlayerScript.y;
        	save.location_x = PlayerScript.x;
        	if (Input.GetKeyDown("s")) {
        		Debug.Log(JsonSave(save));
        	}
        }
    }
}
