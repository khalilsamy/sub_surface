using UnityEngine;
using System.Collections;

public class loose : MonoBehaviour {

	public virus myVirus;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(myVirus.life <= 0 ) Application.LoadLevel("loose");
	}
}
