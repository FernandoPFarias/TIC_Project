using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerContact : MonoBehaviour
{
    
    public Image itemImage;
    
    public PlayerAudioController audioController;
    
    bool canWinLevel = false;

    public string nextLevelName = "Level 1";
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
            SceneManager.LoadScene("GameOver");
            audioController.Hurt();
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
            audioController.PlayGetItem();
        }

        if (collision.gameObject.CompareTag("FinalPoint"))
        {
            if(canWinLevel)
            {
                Debug.Log("ganhou o level");
                SceneManager.LoadScene(nextLevelName);

            }
            else
            {

                Debug.Log("Não ganhou o level");
            }
        }
    }
}
