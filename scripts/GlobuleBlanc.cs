using UnityEngine;
using System.Collections;

public class GlobuleBlanc : MonoBehaviour {
	public GameObject player;
	public float speed = 0.1f;
	public float initialHealth = 10f;
	public float decaySpeed = 0.1f;

	private GameObject playerModel;
	private bool followPlayer = true;
	private bool stickedToPlayer = false;
	private Vector3 initialScale;
	private float health = 10f;

	// Use this for initialization
	void Start () {
		this.player = GameObject.Find("virus");
		this.playerModel = GameObject.Find("Super_subskin");
		this.health = initialHealth;
		this.initialScale = transform.localScale;
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject == playerModel) {
			if (transform.parent != player.transform) {
				transform.parent = player.transform;
				stickedToPlayer = true;
				player.GetComponent<virus>().reduceSpeed();
			}
		}
	}

	// Update is called once per frame
	void Update () {
		if (followPlayer && !stickedToPlayer) {
			transform.Translate ((player.transform.position - transform.position).normalized * speed);
		}
		else if(stickedToPlayer) {
			player.GetComponent<virus>().reduceSpeed();
			health -= decaySpeed;
			transform.localScale = new Vector3(health/initialHealth*this.initialScale[0], health/initialHealth*this.initialScale[1], health/initialHealth*this.initialScale[2]);
		}

		if (health <= 0f) {
			Destroy(this.gameObject);
		}
	}

	bool isStickedToPlayer() {
		return stickedToPlayer;
	}
}
