using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

	public bool play = false;
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "MainCamera")
		{
			play = true;

		}

		
	}

	void Update()
	{
		if(play == true)
		{
			animation.Play();
		}
	}
}
