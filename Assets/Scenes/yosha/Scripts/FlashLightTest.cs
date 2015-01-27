using UnityEngine;
using System.Collections;

public class FlashLightTest : MonoBehaviour 
{
	public GameObject thisCamera;
	public bool lightOn = true;
	public float Sec = 0.1f;
	public float battery = 100;
	private float batteryDuration;
	void Update ()
	{
		Debug.Log (battery);
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
			if( battery >= 0 )
			{
				battery -= Time.deltaTime * Sec;
			}



			
		}
		else if (lightOn == false)
		{
			thisCamera.GetComponent<Light> ();
			this.light.intensity = 0f;
		}



		
		if (battery <= 0)
		{
			thisCamera.GetComponent<Light> ();
			this.light.intensity = 0f;
			battery = 0f;
		}
	}

}
