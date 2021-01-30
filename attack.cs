using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour

{
  public Animator animator;
    public CharacterController monster;
   

    // Start is called before the first frame update
    void awake()
    {
        animator = GetComponent<Animator>();
        monster = GetComponent<CharacterController>();
    }

    // Update is called once per frame

   

    void Update()

    {

        if (Input.GetKey("w"))
        {
            animator.SetBool("Isattacking", true);
        }
        else
        {
            animator.SetBool("Isattacking", false);
        }
      

    }

}