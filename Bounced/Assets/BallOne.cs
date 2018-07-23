using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class BallOne : MonoBehaviour {



	void Update()
	{

	}

	public void OnTriggerEnter2D(Collider2D colInfo)

	{
		if (colInfo.name == "bottomWall")
		Debug.Log ("Ball");
		Destroy (this.gameObject);
	
	}
}
