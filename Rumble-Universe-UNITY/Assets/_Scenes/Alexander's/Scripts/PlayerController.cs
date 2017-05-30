using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Use this for initialization
    public float speed;
    Rigidbody2D rb;
	Animator anim;
	SpriteRenderer Image;
	public GameObject ProjectilePrefab;
	public GameObject Player;
	string Projectile;
	GameObject Cursor;
	float angle;




	void Start () {
        rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator> ();
		Image = GetComponent<SpriteRenderer> ();
		Projectile = "Projectile";
		Cursor = GameObject.FindWithTag ("Cursor");


       
    }

	void Update()
	{
		
		if (Input.GetButtonDown ("Jump") == true) {
			PowerUp ();
		}
		if(Input.GetButtonDown("Fire1")==true){
			FIRE(Projectile);
		}

		angle = Mathf.Abs((Mathf.Atan2 (Mathf.Abs(Cursor.transform.position.y) - Mathf.Abs(transform.position.y), Mathf.Abs(Cursor.transform.position.x) - Mathf.Abs(transform.position.x)))*Mathf.Rad2Deg);

		if (angle > 45f) {
			if (Cursor.transform.position.y - transform.position.y > 0)
				Debug.Log ("above");
			else
				Debug.Log ("Below");
		}

		if (angle < 45f) {
			if (Cursor.transform.position.x - transform.position.x > 0)
				Debug.Log ("right");
			else
				Debug.Log ("Left");
		}


























	}
		

	// Update is called once per frame
	void FixedUpdate () {


		if(rb.velocity.x>0f){
			Image.flipX = false;
			}
        float LeftRight = Input.GetAxisRaw("Horizontal");
        float UpDown = Input.GetAxisRaw("Vertical");
        UpdateMovement(LeftRight, UpDown);

        
        }
    void UpdateMovement(float LeftRight, float UpDown)
    {
		if (LeftRight == -1) {
			Image.flipX = enabled;
		}

        rb.velocity = new Vector2(LeftRight * speed, UpDown * speed);
		anim.SetFloat ("Speed", Mathf.Abs(rb.velocity.x));
        
        
    }

	public void PowerUp()
	{
		anim.SetTrigger ("PowerUp");
	}


	private void FIRE(string Projectile)
	{
		GameObject Clone;
		Clone = Instantiate (Resources.Load (Projectile), gameObject.transform) as GameObject;
		Destroy (Clone, 2.0f);


	}




}
    
