using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartMovement : MonoBehaviour
{
    public static CartMovement Instance;
    public Animator animator;
    public bool cartSelected = true;
    public bool zombieSelected = false;
    public bool wolfSelected = false;
    public bool batSelected = false;
    public GameObject Player;
    public GameObject zombie;
    public GameObject wolf;
    public GameObject bat;
    public bool zombiespawned = false;

    private void Awake()
    {
        Instance = this;
    }
    void Update()
    {
        Physics2D.IgnoreLayerCollision(8, 9);
        Physics2D.IgnoreLayerCollision(9, 10);
        Physics2D.IgnoreLayerCollision(8, 10);

        if (Input.GetKey(KeyCode.Alpha1)){
            cartSelected = true;
            zombieSelected = false;
            wolfSelected = false;
            batSelected = false;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            cartSelected = false;
            zombieSelected = true;
            wolfSelected = false;
            batSelected = false;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            cartSelected = false;
            zombieSelected = false;
            wolfSelected = true;
            batSelected = false;
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            cartSelected = false;
            zombieSelected = false;
            wolfSelected = false;
            batSelected = true;
        }

        if (cartSelected == true)
        {
            if (Input.GetKey(KeyCode.D))
            {
               Player.transform.position += Vector3.right * 1.5f * Time.deltaTime;
                animator.SetFloat("speed", 1);
            }
            else
            {
                animator.SetFloat("speed", 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                Player.transform.position += Vector3.left * 1f * Time.deltaTime;
                animator.SetFloat("isreversing", 1);
            }
            else
            {
                animator.SetFloat("isreversing", 0);
            }
        }
        else
        {
            animator.SetFloat("speed", 0);
            animator.SetFloat("isreversing", 0);
        }

        if (zombieSelected == true)
        {
           
            if (Input.GetKey(KeyCode.D))
            {
                zombie.transform.position += Vector3.right * 1.5f * Time.deltaTime;
            
            }
            if (Input.GetKey(KeyCode.A))
            {
                zombie.transform.position += Vector3.left * 1.5f * Time.deltaTime;
            }

        }
        if (wolfSelected == true)
        {
            if (Input.GetKey(KeyCode.D))
            {
                wolf.transform.position += Vector3.right * 2 * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.A))
            {
                wolf.transform.position += Vector3.left * 2 * Time.deltaTime;
            }
        }
        if (batSelected == true)
        {
            if (Input.GetKey(KeyCode.D))
            {
                bat.transform.position += Vector3.right * 2 * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.A))
            {
                bat.transform.position += Vector3.left * 2 * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.W))
            {
                bat.transform.position += Vector3.up * 2 * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                bat.transform.position += Vector3.down * 2 * Time.deltaTime;
            }
        }
    }  
}
