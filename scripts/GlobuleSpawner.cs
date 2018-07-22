using UnityEngine;
using System.Collections;

public class GlobuleSpawner : MonoBehaviour {
	public GameObject backgroundFolder;
	public GameObject globulePrefab;
	public GameObject player;
	public int nbGlobules;

	// Use this for initialization
	void Start () {
		Component[] backgrounds = backgroundFolder.GetComponentsInChildren<Component> ();

		for (int i = 0; i < nbGlobules; i++) {
			int backgroundId = (int) Random.Range (0, backgrounds.Length - 1);

			Vector3 newGlobulePos = new Vector3(Random.Range(backgrounds [backgroundId].renderer.bounds.center[0] - backgrounds [backgroundId].renderer.bounds.extents[0], backgrounds [backgroundId].renderer.bounds.center[0] + backgrounds [backgroundId].renderer.bounds.extents[0]),
			                                    Random.Range(backgrounds [backgroundId].renderer.bounds.center[1] - backgrounds [backgroundId].renderer.bounds.extents[1], backgrounds [backgroundId].renderer.bounds.center[1] + backgrounds [backgroundId].renderer.bounds.extents[1]),
			             						Random.Range(backgrounds [backgroundId].renderer.bounds.center[2] - backgrounds [backgroundId].renderer.bounds.extents[2], backgrounds [backgroundId].renderer.bounds.center[2] + backgrounds [backgroundId].renderer.bounds.extents[2]));

			Instantiate (globulePrefab, newGlobulePos, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
