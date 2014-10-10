using UnityEngine;
using System.Collections;

public class moveCamera : MonoBehaviour {
	
	void Awake () {
		Application.targetFrameRate = -1;
	}
	
	// Use this for initialization
	void Start () {
		
		rigidbody2D.velocity = new Vector2(8, 0);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
