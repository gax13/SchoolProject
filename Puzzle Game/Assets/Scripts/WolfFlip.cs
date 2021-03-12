using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfFlip : MonoBehaviour
{
    public Rigidbody2D fliprigidbody2D;
    public SpriteRenderer spriteRenderer;
    public bool wolfSelected = false;
    public Animator animator;
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            wolfSelected = false;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            wolfSelected = false;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            wolfSelected = true;
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            wolfSelected = false;
        }



        if (wolfSelected == true)
        {
            if (Input.GetKey(KeyCode.D))
            {
                spriteRenderer.flipX = false;
            }
            if (Input.GetKey(KeyCode.A))
            {
                spriteRenderer.flipX = true;
            }

            if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.A))
            {

                animator.SetFloat("wolfspeed", 1);
            }
            else
            {
                animator.SetFloat("wolfspeed", 0);
            }

        }
        else
        {
            animator.SetFloat("wolfspeed", 0);
        }
    }
}
