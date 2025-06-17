using UnityEngine;
using UnityEngine.InputSystem;

public class Fireball : MonoBehaviour
{

    private Animator animator; // Reference to the Animator component
                               // Start is called once before the first execution of Update after the MonoBehaviour is created
    private SpriteRenderer sR;
    void Start()
    {
        // sR = GetComponent<SpriteRenderer>();
        // animator = GetComponent<Animator>();
        // // Set the fireball to be destroyed after 2 seconds
        // Destroy(gameObject, 5);
        // // animator.SetInteger("type", 1); // Set the animation type to 1
        // int r = Random.Range(0, 3); // Randomly select an animation type
        // animator.SetInteger("type", r); // Set the animation type to the random value

        // sR.flipX = false; // Flip the sprite to face right
        // if (transform.position.x < 0)
        // {
        //     sR.flipX = true; // Flip the sprite to face left
        // }
        // transform.localScale = new Vector3(-1, 1, 1); // Scale the fireball to half its size

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * 5f); // Move the fireball forward at a speed of 5 units per second
        Destroy(gameObject, 5f); // Destroy the fireball after 5 seconds
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject); // Destroy the fireball on collision
        Debug.Log("Fireball hit: " + collision.gameObject.name); // Log the name of the object hit  

    }

   

            
        
        

    }
    

    

