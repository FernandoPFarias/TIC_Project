using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerContact : MonoBehaviour
{
    
    public Image[] eggImage;
    public int eggsCollected = 0;
    public int totalEggs = 3;
    
    
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
            eggsCollected++;
            Debug.Log("Pegou um ovo!: " + eggsCollected);

            Destroy(collision.gameObject);
            
            audioController.PlayGetItem();

            UpdadeEggUI();
        }


        if (collision.gameObject.CompareTag("FinalPoint"))
        {
            if(eggsCollected >= totalEggs)
            {
                Debug.Log("Todos foram coletados");
                SceneManager.LoadScene(nextLevelName);

            }
            else
            {

                Debug.Log("Nta faltando ovo");
            }
        }
    }



    void UpdadeEggUI()
    {
        for (int i = 0; i < eggsCollected; i++)
        {
            eggImage[i].color = Color.white;
        }
    }
}
