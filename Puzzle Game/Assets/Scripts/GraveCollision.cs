﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraveCollision : MonoBehaviour
{
    public GameObject Player;
    public GameObject DireWolf;
    public GameObject Zombie;
    public GameObject barrier;
    public bool IsZombieInHole = false;
    public bool wolfcollision;
    public bool zombiecollision;
    public bool isHole;
    private SpriteRenderer spriteRenderer;
    public Sprite Grave;
    public Sprite Hole;
    public Sprite zombieInHole;
   
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Update()
    {

        if (wolfcollision == true)
        {
            if  (CartMovement.Instance.zombiespawned == false && IsZombieInHole == false)
            {
                Debug.Log("Wolfcollision");
                Zombie.transform.position = new Vector3(3, -1, 0);
                CartMovement.Instance.zombiespawned = true;
                isHole = true;
                ChangeSprite1();
                barrier.transform.Translate(0, 5, 0);
            }
            wolfcollision = false;
        }
        if (zombiecollision == true)
        {
            if (isHole == true)
            {
                Debug.Log("zombiecollision");
                Zombie.transform.position = new Vector3(11, 2, 0);
                CartMovement.Instance.zombiespawned = false;
                ChangeSprite2();
                barrier.transform.Translate(0, -5, 0);
                IsZombieInHole = true;
            }
            zombiecollision = false;
        }
    }

     void OnTriggerEnter2D(Collider2D col)
    {
         if (col.gameObject.name == "Dire wolf")
         {
            wolfcollision = true; 
         }


        if (col.gameObject.name == "zombie")
        {
            zombiecollision = true;
        }
    }

    void ChangeSprite1()
    {
        spriteRenderer.sprite = Hole;
    }
    void ChangeSprite2()
    {
        spriteRenderer.sprite = zombieInHole;
    }
}
