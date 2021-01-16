using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{


    public float inputX;
    public float inputY;

    public float velocity;
    public float gravity = 5f;
    public float _speed = 50f;
    public float jump_Force = 10f;
    public CharacterController body;
    public float _rotationSpeed = 180;
    public Camera mainCamera;



    void awake()
    {
        body = GetComponent<CharacterController>(); //asign controller to contoller

    }



    private Vector3 rotation;
    public void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");

        if (body.isGrounded)
        {
            velocity = -gravity * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                velocity = jump_Force;
            }

        }
        else
        {
            velocity = -gravity * Time.deltaTime;

        }
        Vector3 mouveCharacter = new Vector3(inputX * _speed, velocity, inputY * _speed);
        body.Move(mouveCharacter * Time.deltaTime);
        mouveCharacter.y = velocity;


        Vector3 movementDirection = new Vector3(Input.GetAxisRaw("Horizontal")
            , 0, Input.GetAxisRaw("Vertical"));
        if (movementDirection != Vector3.zero)
        {

            //this works to make the character moves towards the direction 
            this.transform.rotation = Quaternion.Euler(0, mainCamera.transform.rotation.eulerAngles.y, 0);
            //this works to rotate the character in the direction of it's movment
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(
                movementDirection), 0.15f);
        }







    }
}