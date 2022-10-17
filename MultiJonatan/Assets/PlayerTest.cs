using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    CharacterController Character; 
    Animator anim;
    private void Awake()
    {
        Character = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Character.Move(Vector3.forward);
            anim.SetBool("Attack", true);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Character.Move(Vector3.back);
            anim.SetBool("Attack", true);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Character.Move(Vector3.left);
            anim.SetBool("Attack", true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Character.Move(Vector3.right);
            anim.SetBool("Attack", true);
        }
    }
}
