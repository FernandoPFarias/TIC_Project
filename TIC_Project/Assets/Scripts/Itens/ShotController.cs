using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    public GameObject explosionPrefab;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);

            FindObjectOfType<EffectsController>().PlayEnemyDeath();
        }

        if(collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            FindObjectOfType<EffectsController>().eggExplosion();
        }

        if (collision.gameObject.CompareTag("Lateral"))
        {
            Destroy(gameObject);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            FindObjectOfType<EffectsController>().eggExplosion();
        }

    }
}
