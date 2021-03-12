using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHangingCollision : MonoBehaviour
{
    public GameObject Zombie; 
    public bool batcollision;
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
            Debug.Log("batcollision");
            Zombie.transform.position = new Vector3(-1, -1, 0);
            CartMovement.Instance.zombiespawned = true;
            ChangeSprite2();
            batcollision = false;
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
