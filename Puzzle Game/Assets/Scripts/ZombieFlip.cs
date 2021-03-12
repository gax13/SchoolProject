using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFlip : MonoBehaviour
{
    public Rigidbody2D fliprigidbody2D;
    public SpriteRenderer spriteRenderer;
    public bool cartSelected = true;
    public bool zombieSelected = false;
    public bool wolfSelected = false;
    public Animator animator;
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            zombieSelected = false;    
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            zombieSelected = true;    
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            zombieSelected = false;     
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            zombieSelected = false;
        }


        if (zombieSelected == true)
        {
            if (Input.GetKey(KeyCode.D))
            {
                spriteRenderer.flipX = false;
            }
            if (Input.GetKey(KeyCode.A))
            {
                spriteRenderer.flipX = true;
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
            {

                animator.SetFloat("zombiespeed", 1);
            }
            else
            {
                animator.SetFloat("zombiespeed", 0);
            }
        }
        else
        {
            animator.SetFloat("zombiespeed", 0);
        }
    }
}
