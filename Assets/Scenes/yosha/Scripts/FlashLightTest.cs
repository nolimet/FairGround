using UnityEngine;
using System.Collections;

public class FlashLightTest : MonoBehaviour {
	public GameObject thisCamera;
	public bool lightOn = true;
	void Update ()
	{

		if(Input.GetKeyDown (KeyCode.L))
		{
			if(lightOn == false)
			{
				lightOn = true;
			}
			else if(lightOn == true)
			{
				lightOn = false;
			}
		}

		if(lightOn == true)
		{
			thisCamera.GetComponent<Light> ();
			this.light.intensity = 1.5f;
			
		}
		else if (lightOn == false)
		{
			thisCamera.GetComponent<Light> ();
			this.light.intensity = 0f;
		}

	}
}
