
using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour
{
    private Vector3 move;
    private CharacterController characterController;
    private float movementSpeed = 4;
    private float jumpPower = 15;
    private float gravity = 40;


    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }


    void Update()
    {
        move.x = Input.GetAxis("LeftJoystickX+") * movementSpeed;
        move.x = Input.GetAxis("LeftJoystickX-") * movementSpeed;
        move.z = Input.GetAxis("LeftJoystickY+") * movementSpeed;
        move.z = Input.GetAxis("LeftJoystickY-") * movementSpeed;

        if (characterController.isGrounded)
        {
            move.y = 0;

            if (Input.GetButtonDown("A"))
            {
                move.y = jumpPower;
            }
        }


        move.y -= gravity * Time.deltaTime;

        characterController.Move(move * Time.deltaTime);

    }

}
