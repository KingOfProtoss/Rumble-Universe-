using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
	public GameObject Player;
	public GameObject Cursor;
	Rigidbody2D rb;
	public float speed;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();

		Vector3 dir = Player.transform.position - Cursor.transform.position;
		float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);


		Vector3 sp = Cursor.transform.position - Player.transform.position;
		rb.AddForce (sp.normalized * speed);



	}



}
