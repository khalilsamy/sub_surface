using UnityEngine;
using System.Collections;

public class vaccins : MonoBehaviour {
    public GameObject coeur;
	// Use this for initialization
	void Start () {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(coeur.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
