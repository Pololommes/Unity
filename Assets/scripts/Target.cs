using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject targetPrefab; // Reference to the target prefab
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "projectile")
        {
            createTarget(); // Create a new target when hit by a projectile
            Destroy(collision.gameObject); // Destroy the projectile on collision
            Destroy(gameObject); // Destroy the target on collision
            Debug.Log("Target hit: " + gameObject.name); // Log the name of the
        }
    }
    void createTarget()
    {
        float x = Random.Range(4.5f, -4.5f); // Randomly generate an x position within the range of -4 to 4
        float y = Random.Range(-4.5f, 4.5f); // Randomly generate a y position within the range of -4 to 4
        // Instantiate a new target at the current position
        GameObject newTarget = Instantiate(gameObject, transform.position, Quaternion.identity);
        newTarget.transform.localScale = new Vector3(1, 1, 1); // Set the scale of the new target
    }
}
