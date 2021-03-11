using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfFlip : MonoBehaviour
{
    public Rigidbody2D fliprigidbody2D;
    public SpriteRenderer spriteRenderer;
    public bool cartSelected = true;
    public bool zombieSelected = false;
    public bool wolfSelected = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            cartSelected = true;
            zombieSelected = false;
            wolfSelected = false;

        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            cartSelected = false;
            zombieSelected = true;
            wolfSelected = false;

        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            cartSelected = false;
            zombieSelected = false;
            wolfSelected = true;

        }
        // if (fliprigidbody2D.velocity.x >= 0f)
        //{
        //    spriteRenderer.flipX = false;

        // }
        // if (fliprigidbody2D.velocity.x < 0f)
        //  {
        //    spriteRenderer.flipX = true;


        // }
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
        }
    }
}
