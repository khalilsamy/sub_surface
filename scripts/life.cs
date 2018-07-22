using UnityEngine;
using System.Collections;

public class life : MonoBehaviour {

	public virus my_virus;
	public GUIText life_text;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		life_text.text ="life : " + my_virus.life.ToString();
	}
}
