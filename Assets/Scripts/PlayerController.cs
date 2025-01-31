using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public Rigidbody2D playerRigidbody;

	// Use this for initialization
	void Start () {
        playerRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        playerRigidbody.linearVelocity = movement * 2;

        if(Input.GetKeyDown(KeyCode.F)) {
            // Task 1: Start Your Coroutine Here
        }
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Wall") {
            playerRigidbody.linearVelocity = Vector2.zero;
        }
    }

    // Task 1: Write Your Coroutine Here

}