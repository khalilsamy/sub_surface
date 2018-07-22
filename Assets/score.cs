using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

    public virus My_virus;
    public GUIText score_texte;
	// Use this for initialization
	void Start () {
		/*
			score_texte.pixelOffset.x = Screen.width -200 ;
		score_texte.pixelOffset.y = Screen.height - 200;*/
	}
	
	// Update is called once per frame
	void Update () {
        score_texte.text ="Score : " + My_virus.score.ToString();
	}
}
