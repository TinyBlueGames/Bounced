
using UnityEngine;

public class BottomDeath : MonoBehaviour {

	public GameObject BallOne;
	public float life;
	public void OnTriggerEnter2D(Collider2D colInfo)

	{
		if (colInfo.name == "Ball(Clone)")
			life -= 1;
			Invoke ("SpawnBallOne", 2);
		Debug.Log ("Hit");
		Debug.Log (life);
	}
		

	public void SpawnBallOne()
	{
		Instantiate (BallOne, transform.position, transform.rotation);
	}

	void Update()
	{
		if (life == 0)
			Debug.Log ("Game Over");
	}
	void Start()
	{
		life = 3;
	
	}
}
