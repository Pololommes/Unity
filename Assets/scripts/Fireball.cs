using UnityEngine;

public class Fireball : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * 2f); // Move the fireball forward at a speed of 5 units per second
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject); // Destroy the fireball on collision
        Debug.Log("Fireball hit: " + collision.gameObject.name); // Log the name of the object hit  
        
    }
}
