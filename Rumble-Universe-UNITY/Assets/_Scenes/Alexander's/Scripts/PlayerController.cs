using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Use this for initialization
    public float speed;
    Rigidbody2D rb;
    public bool Keyboard = false;
	Animator anim;
	SpriteRenderer Image;



	void Start () {
        rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator> ();
		Image = GetComponent<SpriteRenderer> ();
       
    }

	void Update()
	{
		
		if (Input.GetButtonDown ("Jump") == true) {
			PowerUp ();
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




}
    
