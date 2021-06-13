using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHangingCollisionLevel52 : MonoBehaviour
{
    public GameObject Zombie;
    public bool batcollision;
    public bool zombieloose = false;
    private SpriteRenderer spriteRenderer;
    public Sprite zombieHanging;
    public Sprite Rope;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (batcollision == true)
        {
            if (CartMovement.Instance.zombiespawned == false && zombieloose == false)
            {
                Debug.Log("batcollision");
                Zombie.transform.position = new Vector3(2, -1, 0);
                CartMovement.Instance.zombiespawned = true;
                ChangeSprite2();
                batcollision = false;
                zombieloose = true;
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D col)
    {


        if (col.gameObject.name == "Bat")
        {
            batcollision = true;
        }
    }
    public void ChangeSprite2()
    {
        spriteRenderer.sprite = Rope;
    }


}
