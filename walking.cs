using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{

    public float inputX;
    public float inputY;
    public float velocity;
    public float gravity = 5f;
    public float speed = 10f;
    public float jump_force = 10f;
    public CharacterController body;
    public float _rotationSpeed = 10f;

    void awake()
    {
        body = GetComponent<CharacterController>();
    }
    void mouvePlayer()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");
        Vector3 mouveCharacter = new Vector3(inputX * speed, velocity
            , inputY * speed) ;
        body.Move(mouveCharacter * Time.deltaTime);
        mouveCharacter.y = velocity;
        Gravity();
        //Rotation();
    }
    void Gravity()
    {
        if (body.isGrounded)
        {
            velocity -= gravity * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                velocity = jump_force;
            }
        }
        else
        {
            velocity = gravity * Time.deltaTime;
        }
    }




































}

















 