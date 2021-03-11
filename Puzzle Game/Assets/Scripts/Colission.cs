using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colission : MonoBehaviour
{
    public GameObject Zombie;
    public bool zombiespawned = true;
    private SpriteRenderer spriteRenderer;
    public Sprite Hole;
    public Sprite zombieInHole;



    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();  
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
      
       if (col.gameObject.name == "zombie")
        {
            Debug.Log("zombiecolission");
            Zombie.transform.position = new Vector3(11, 2, 0);
            zombiespawned = false;
           ChangeSprite();
            foreach (Transform child in transform)

            {
                GameObject.Destroy(child.gameObject);
            }

        }
      
    }

           public void ChangeSprite()
    {
        spriteRenderer.sprite = zombieInHole;
    }
    public void Update()
    {
      
    }
       
    }
