using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject Zombie;
    public GameObject barrier;
    public bool zombiecollision;
    private SpriteRenderer spriteRenderer;
    public Sprite Hole;
    public Sprite zombieInHole;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();  
    }

    private void Update()
    {
        if (zombiecollision == true)
        {
            Debug.Log("zombiecollision");
            Zombie.transform.position = new Vector3(11, 2, 0);
            CartMovement.Instance.zombiespawned = false;
            ChangeSprite2();
            barrier.transform.Translate(0, -5, 0);
            zombiecollision = false;
        }
    }
    public void OnTriggerEnter2D(Collider2D col)
    {

       
        if (col.gameObject.name == "zombie")
        {
            zombiecollision = true;
        }
    }
         public void ChangeSprite2()
         {
             spriteRenderer.sprite = zombieInHole;
         }


}
