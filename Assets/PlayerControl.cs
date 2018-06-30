using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
public float LocalSpeed;
public float SpeedX;
public float SpeedY;

void FixedUpdate() {
	/*
	if(Input.GetKey(KeyCode.A)) {
		SpeedX = LocalSpeed *  Input.GetAxis("Horizontal")  * Time.deltaTime;
	}
	if(Input.GetKey(KeyCode.D)) {
		SpeedX = LocalSpeed *  Input.GetAxis("Horizontal") * Time.deltaTime;
	}
	if(Input.GetKey(KeyCode.W)) {
		SpeedY = LocalSpeed *  Input.GetAxis("Vertical") * Time.deltaTime;
	}
	if(Input.GetKey(KeyCode.S)) {
		SpeedY = LocalSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
	}
	//В этом блоке персонаж плавно ускоряется, оставлю эту хрень для камеры
	*/
	if(Input.GetKey(KeyCode.A)) {
		SpeedX = -LocalSpeed;
	}
	if(Input.GetKey(KeyCode.D)) {
		SpeedX = LocalSpeed;
	}
	if(Input.GetKey(KeyCode.W)) {
		SpeedY = LocalSpeed;
	}
	if(Input.GetKey(KeyCode.S)) {
		SpeedY = -LocalSpeed;
	}
	transform.Translate(SpeedX, SpeedY, 0);
	SpeedX = 0;
	SpeedY = 0;
	
	
}
}
