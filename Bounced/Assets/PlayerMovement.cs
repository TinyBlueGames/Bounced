using UnityEngine;
using System.Collections;



public class PlayerMovement : MonoBehaviour {
	public KeyCode goRight;
	public KeyCode goLeft;
	public float goSpeed = 15f;
	private Rigidbody2D rigBody;

	void Awake (){
		rigBody = GetComponent<Rigidbody2D>(); 
	}



	void Update () {
		if (Input.GetKey (goRight)) {
			rigBody.velocity = new Vector2(goSpeed, 0);
		} else if (Input.GetKey (goLeft)) {
			rigBody.velocity = new Vector2(-goSpeed, 0);
		} else {
			rigBody.velocity = new Vector2(0, 0);
		}

	}
}