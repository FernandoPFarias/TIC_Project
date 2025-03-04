using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerContact : MonoBehaviour
{
    
    public Image itemImage;
    
    bool canWinLevel = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("tocou no inimigo");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Item")) 
        {
            Debug.Log("Pegou um ovo");
            Destroy(collision.gameObject);
            itemImage.color = Color.white;
            canWinLevel = true;
        }

        if (collision.gameObject.CompareTag("FinalPoint"))
        {
            if(canWinLevel)
            {
                Debug.Log("ganhou o level");

            }
            else
            {

                Debug.Log("Não ganhou o level");
            }
        }
    }
}
