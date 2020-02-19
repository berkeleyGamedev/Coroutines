using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    bool moving;

	// Use this for initialization
	void Start () {
        moving = false;
	}
	
	// Update is called once per frame
	void Update () {
		// Don't use Update for this task
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Task 3: Start Your Coroutine Here
    }

    // Task 3: Write Your Coroutine Here
}
