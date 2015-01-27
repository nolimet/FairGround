using UnityEngine;
using System.Collections;

public class TempMoveScript : MonoBehaviour {
	public GameObject thisthisCamera;

	public float speed = 1;
	// left arrow--------------------
	public bool pressedLeft = false;
	//-------------------------------
	// right arrow-------------------
	public bool pressedRight = false;
	//-------------------------------
	// up arrow----------------------
	public bool pressedUp = false;
	//-------------------------------
	// down arrow--------------------
	public bool pressedDown = false;
	//-------------------------------
	// space-------------------------
	//-------------------------------
	void Update () 
	{
		// input left ---------------------------
		if(Input.GetKeyDown (KeyCode.LeftArrow))
		{
			pressedLeft = true;
		}
		else if(Input.GetKeyUp (KeyCode.LeftArrow))
		{
			pressedLeft = false;
		}
		//------------------------------------------
		// input up --------------------------------
		if(Input.GetKeyDown (KeyCode.UpArrow))
		{
			pressedUp = true;
		}
		else if(Input.GetKeyUp (KeyCode.UpArrow))
		{
			pressedUp = false;
		}
		//-------------------------------------------
		// input down -------------------------------
		if(Input.GetKeyDown (KeyCode.DownArrow))
		{
			pressedDown = true;
		}
		else if(Input.GetKeyUp (KeyCode.DownArrow))
		{
			pressedDown = false;
		}
		//-------------------------------------------
		// input right -------------------------------
		if(Input.GetKeyDown (KeyCode.RightArrow))
		{
			pressedRight = true;
		}
		else if(Input.GetKeyUp (KeyCode.RightArrow))
		{
			pressedRight = false;
		}
		//------------------------------------------
		// input space -----------------------------
		//------------------------------------------
		// rotate ----------------------------------
		if(pressedLeft == true)
		{
			thisthisCamera.transform.Rotate(0,-1,0);
		}
		else if(pressedRight == true)
		{
			thisthisCamera.transform.Rotate(0,1,0);
		}
		//---------------------------------------------
		// move ---------------------------------------
		if(pressedUp == true)
		{
			thisthisCamera.transform.Translate(0,0,0.01f);
		}
		else if(pressedDown == true)
		{
			thisthisCamera.transform.Translate(0,0,-0.01f);
		}
		//----------------------------------------------
		// jump ----------------------------------------
		//----------------------------------------------
	}
}
