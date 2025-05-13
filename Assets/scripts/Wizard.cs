using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class Wizard : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            movement += Vector3.up;
        }

        if (Input.GetKey(KeyCode.S))
        {
            movement += Vector3.down;
        }

        if (Input.GetKey(KeyCode.D))
        {
            movement += Vector3.right;
        }

        if (Input.GetKey(KeyCode.A))
        {
            movement += Vector3.left;
        }

        movement.Normalize();

        // Bewegung anwenden
        transform.position += movement * speed * Time.deltaTime;
    }

     private void OnCollisionEnter2D(Collision2D other)
     {
        if (other.gameObject.CompareTag("Fireball"))
        {
            Destroy(other.gameObject); // Zerstöre den Fireball
          
        }
        if (other.gameObject.CompareTag("Target"))
        {
            Destroy(other.gameObject); // Zerstöre das Ziel
           
        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); // Zerstöre den Feind
     }
     
     }
}

