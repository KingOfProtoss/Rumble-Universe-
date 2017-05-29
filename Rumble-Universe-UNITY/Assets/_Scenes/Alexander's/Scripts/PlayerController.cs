using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Use this for initialization
    public float speed;
    Rigidbody2D rb;
    public bool Keyboard = false;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
       
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        float LeftRight = Input.GetAxis("Horizontal");
        float UpDown = Input.GetAxis("Vertical");
        UpdateMovement(LeftRight, UpDown);
        
        }
    void UpdateMovement(float LeftRight, float UpDown)
    {
        Keyboard = true;
        rb.velocity = new Vector2(LeftRight * speed, UpDown * speed);
        
        
    }
    public void Update()
    {
        if (Keyboard == false)
            FreezePlayer();
    }
    public void FreezePlayer()
    {
        Transform.SetP
    }
}
