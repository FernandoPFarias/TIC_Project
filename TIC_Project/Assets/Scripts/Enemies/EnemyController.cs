using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float Speed = 3.5f;
    public Transform[] Destinations;

    int currentIndex = 0;

    Animator animator;
    SpriteRenderer sprite;

    void Start()
    {
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {   
        
        if(Destinations.Length == 0)
        {   
            animator.SetBool("B_isWalking",false);
            return;
        }
        animator.SetBool("B_isWalking", true);
        
        

        var currentDestinations = Destinations[currentIndex];

        sprite.flipX = transform.position.x > currentDestinations.position.x;


        transform.position = Vector3.MoveTowards(transform.position, currentDestinations.position, Speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, currentDestinations.position) <= 0.1f)
        {
            currentIndex =  (currentIndex + 1) % Destinations.Length;
        }

    }
}
