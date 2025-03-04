using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtack : MonoBehaviour
{
    public GameObject ShotPrefab;

    public float ShootForce = 10f;

    SpriteRenderer sprite;

    bool canAtack = true;

    void Start()
    {
       
        sprite = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ShotNewEgg()
    {        // Ajusta a posição do FirePoint para sempre ficar na frente do player
        var direction = sprite.flipX ? 1 : -1;
        Vector3 firePosition = transform.position + new Vector3(direction * 0.5f, -0.2f, 0);

        // Instancia o projétil
        var newProjectile = Instantiate(ShotPrefab, firePosition, Quaternion.identity);
        Rigidbody2D rbProjectile = newProjectile.GetComponent<Rigidbody2D>();


        if (rbProjectile != null)
        {
            rbProjectile.velocity = new Vector2(direction * ShootForce, 0);
        }

        Destroy(newProjectile, 2f);
    }
    public void SetCanAttack()
    {
        canAtack = true;
    }
}
