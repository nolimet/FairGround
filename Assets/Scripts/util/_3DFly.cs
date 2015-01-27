﻿using UnityEngine;
using System.Collections;

[AddComponentMenu("Camera-Control/3DFly")]
[RequireComponent(typeof(MouseLook))]
public class _3DFly : MonoBehaviour
{
    private bool mouseRightDown;
    private bool NoRigiBody = false;

    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        if (hor != 0 || ver != 0)
        {
            if (!NoRigiBody&& rigidbody != null)
            {
               // if (Input.GetAxis("Sprint")>0)
                //    rigidbody.AddRelativeForce((new Vector3(hor, 0, ver) * 120f) * Time.deltaTime);
                //else
                    rigidbody.AddRelativeForce((new Vector3(hor, 0, ver) * 60f) * Time.deltaTime);
            }
            else
            {
                NoRigiBody = true;
              //  if (Input.GetAxis("Sprint") > 0)
                //    transform.Translate((new Vector3(hor, 0, ver) * 12f) * Time.deltaTime);
               // else
                    transform.Translate((new Vector3(hor, 0, ver) * 6f) * Time.deltaTime);
            }
        }
        else
        {
            if (!NoRigiBody && rigidbody != null)
            rigidbody.velocity = Vector3.zero;
        }
    }
}
