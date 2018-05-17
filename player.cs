using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	float screenHalfWidthInRealWorld;
	public float speed =5.5f;
	Rigidbody2D rb;
	//public Transform playerObject ;
	Vector2 targetPosition ;


	  void Start () {
		float playerHalfWidth = transform.localScale.x / 2f;
		screenHalfWidthInRealWorld = Camera.main.aspect * Camera.main.orthographicSize - playerHalfWidth; 
		//targetPosition = playerObject.position;



		rb = GetComponent<Rigidbody2D> ();


	}
	
	// Update is called once per frame
	void Update () {
		//float inputX = Input.GetAxisRaw ("Horizontal");

		//float velocity = inputX * speed;
		//transform.Translate (Vector2.right*velocity*Time.deltaTime);
		//playerObject.position = Vector3.Lerp(playerObject.position , targetPosition , Time.deltaTime*7);

		if (transform.position.x < -screenHalfWidthInRealWorld) {
			transform.position = new Vector2(-screenHalfWidthInRealWorld,transform.position.y);
		} else if (transform.position.x >= screenHalfWidthInRealWorld) {
			transform.position = new Vector2(screenHalfWidthInRealWorld,transform.position.y);
		}

	}

	void OnTriggerEnter2D(Collider2D triggerCollider){

		if (triggerCollider.tag == "Falling Block") {
			FindObjectOfType<GameOver> ().OnGameOver ();
			Destroy (gameObject);
		}
	}

	//public void OnTouchStay(Vector2 point ){
	//	targetPosition = new Vector2 (point.x, targetPosition.y);
		
	//}

	public void MoveLeft(){
		rb.velocity = new Vector2 (-speed, 0);
		
		
		
	}

	public void MoveRight(){
		rb.velocity = new Vector2 (speed, 0);

	}

	public void stop(){
		rb.velocity =  Vector2.zero;

	}


}


