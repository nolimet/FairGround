using UnityEngine;
using System.Collections;

public class DumbMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.LogWarning("I am not needed");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis(Axis.Horizontal) != 0)
            transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis(Axis.Horizontal));

	}
}
