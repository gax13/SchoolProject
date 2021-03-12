using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatFlip : MonoBehaviour
{
    public Rigidbody2D fliprigidbody2D;
    public SpriteRenderer spriteRenderer;
    public bool cartSelected = true;
    public bool zombieSelected = false;
    public bool wolfSelected = false;
    public bool batSelected = false;
    public Animator animator;
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            batSelected = false;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            batSelected = false;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            batSelected = true;
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            batSelected = false;
        }



        if (batSelected == true)
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
