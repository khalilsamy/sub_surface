using UnityEngine;
using System.Collections;

public class coeur : MonoBehaviour {
    public GameObject virus;
    float distance,blending;
	// Use this for initialization
	void Start () {
        blending = 0.0f;
        renderer.material.shader = Shader.Find("Custom/blend");
	}
	
	// Update is called once per frame
	void Update () {
        distance = Vector3.Distance(virus.transform.position, transform.position);
        if (distance < 40)
        {
            blending += 0.01f;
            renderer.material.SetFloat("_Blend", blending);
        }
		if (blending > 0.8) Application.LoadLevel("win");
	}
}
