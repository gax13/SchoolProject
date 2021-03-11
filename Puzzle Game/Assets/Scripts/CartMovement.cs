using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartMovement : MonoBehaviour
{
    public Animator animator;
    public bool cartSelected = true;
    public bool zombieSelected = false;
    public bool wolfSelected = false;
    public bool batSelected = false;
    public GameObject Player;
    public GameObject zombie;
    public GameObject wolf;

    void Update()
    {
        Physics2D.IgnoreLayerCollision(8, 9);
        Physics2D.IgnoreLayerCollision(9, 10);
        Physics2D.IgnoreLayerCollision(8, 10);

        if (Input.GetKey(KeyCode.Alpha1)){
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
                Player.transform.position += Vector3.left * 1.5f * Time.deltaTime;
            }
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
        Vector3 position = transform.position;
        position.y = -1;
        transform.position = position;
      
    }

   
}
