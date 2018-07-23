
using UnityEngine;

public class Startup : MonoBehaviour {

	public BoxCollider2D bottomWall;
	public BoxCollider2D leftWall;
	public BoxCollider2D rightWall;
	public BoxCollider2D topWall;

	public BoxCollider2D platform;
	public GameObject BallOne;
	
	void Start()
	{
		bottomWall.size = new Vector2(Camera.main.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 0.1f);
		bottomWall.offset = new Vector2(0f, Camera.main.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 5.5f);

		leftWall.size = new Vector2(0.1f, Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height * 4f, 0f)).y);
		leftWall.offset = new Vector2(Camera.main.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x + 0.65f, 0f);

		rightWall.size = new Vector2(0.1f, Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height * 4f, 0f)).y);
		rightWall.offset = new Vector2(Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 0.65f, 0f);

		topWall.size = new Vector2(Camera.main.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 0.1f);
		topWall.offset = new Vector2(0f, Camera.main.ScreenToWorldPoint(new Vector3(0f, Screen.height *2, 0f)).y + 0.6f);
		Invoke ("SpawnBallOne", 5);
	}
	void Update () {
		

	}

	public void SpawnBallOne()
	{
		Instantiate (BallOne, transform.position, transform.rotation);
	}
}
