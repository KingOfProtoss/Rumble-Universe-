using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	GameObject Player;
	Rigidbody2D rb;
	public float enemyspeed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		Player = GameObject.FindWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		Vector3 attack = Player.transform.position - transform.position;
		rb.velocity =  (attack.normalized * enemyspeed);
	}
}
