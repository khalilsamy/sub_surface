using UnityEngine;
using System.Collections;

public class plane_play : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnGUI() {
		Event e = Event.current;
		if (e.isMouse)
			Debug.Log("Detected a mouse event!");
		
	}

	void OnMouseDown() {
		Application.LoadLevel("instruction");
		//if(life ==0) 
	}

	// Update is called once per frame

	void Update () {
	
	}
}
