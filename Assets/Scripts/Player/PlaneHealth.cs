using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneHealth : MonoBehaviour {
    public Rect a;
    Color mat;
    float newAlpha;
    public PlayerHealth s;
    private GUIStyle guiStyle = new GUIStyle();
    // Use this for initialization
    void Start () {
        mat = GetComponent<MeshRenderer>().material.color;
        s = GameObject.Find("SwordSpawn").GetComponent<PlayerHealth>();
	}
	
	// Update is called once per frame
	void Update () {
        
        if (s.hp == 5) {
            newAlpha = 0;
        } else {
             newAlpha = 1 - (0.2f * s.hp);
        }
     
        GetComponent<Renderer>().material.color = new Color(GetComponent<Renderer>().material.color.r, GetComponent<Renderer>().material.color.g, GetComponent<Renderer>().material.color.b, newAlpha);
    }
    private void OnGUI()
    {
        if (newAlpha >= 1)
        {
            //a.x = Screen.width/2;
            //a.y = Screen.height/2;
            a.x = 250;
            a.y = 150;
            guiStyle.fontSize = 60;
            guiStyle.font = (Font)Resources.Load("mangatb");
            guiStyle.alignment = TextAnchor.MiddleCenter;
            a.height = Screen.height;
             a.width = Screen.width;
    
            GUI.Label(a, "GameOver \n ゲームオーバー\n Kills: " + SpawnEnemy.killcount, guiStyle);
            Time.timeScale = 0;
        }
    }

}
