using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class goToNextScene : MonoBehaviour {

	void Awake () {
		Application.targetFrameRate = -1;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)){
			var ray = Camera.main.ScreenPointToRay (Input.mousePosition); 
			
			var origin = new Vector2 (ray.origin.x, ray.origin.y); 
			
			var hit = Physics2D.Raycast (origin, new Vector2 (0, 0));	
			
			if (hit) {
				if(hit.transform.name == "Cube") {

					Application.LoadLevel ("scenetwo");
				}
			} 
	
		}
	}
}
