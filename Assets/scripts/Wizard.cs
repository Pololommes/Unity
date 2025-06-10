using System.Collections;

using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Categorization;
using UnityEngine.Rendering;

public class Wizard : MonoBehaviour

{

    private Animator animator; // Reference to the Animator component
    private SpriteRenderer sR;
    public GameObject FireballPrefab;

    void Update()

    {
        GetComponent<Animator>().SetBool("Walking", true);
        transform.localScale = new Vector3(-1, 1, 1);
        Movement();

        Casting();

    }

    private void Movement()

    {

        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.W))

        {

            movement = movement + new Vector3(0, 1, 0);

        }

        if (Input.GetKey(KeyCode.S))

        {

            movement += Vector3.down;

        }

        if (Input.GetKey(KeyCode.A))

        {

            movement += Vector3.left;

        }

        if (Input.GetKey(KeyCode.D))

        {

            movement += Vector3.right;

        }

        // Option 1

        if (Input.GetKey(KeyCode.W) ^ Input.GetKey(KeyCode.S))

        {

            if (Input.GetKey(KeyCode.A) ^ Input.GetKey(KeyCode.D))

            {

                movement *= 0.7f;

            }

        }

        // Option 2 easy Solution

        movement.Normalize();

        // Option 3 bei Pseudo Controller

        if (movement.magnitude > 1)

        {

            movement.Normalize();

        }
        if (movement.magnitude > 0)
        {
            GetComponent<Animator>().SetBool("Walking", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Walking", false);
        }

        transform.position += movement * Time.deltaTime * 3;

    }

    private void Casting()

    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Cooldown();

            Vector3 position = transform.position + new Vector3(0.9f, 0.8f, 0);

            GameObject obj = Instantiate(FireballPrefab, position, Quaternion.identity);

            GetComponent<Animator>().SetBool("shooting", true);
        }
        else

        {

            GetComponent<Animator>().SetBool("shooting", false);

        }

    }
    private void hurtPlayer()

    {

        // if (Input.GetKeyDown(KeyCode.H))

        // {

        //     GetComponent<Animator>().SetBool("hurt", true);

        // }
        // else if (Input.GetKeyUp(KeyCode.H))

        // {

        //     GetComponent<Animator>().SetBool("hurt", false);

        // }

    }
   
   private void Cooldown()
    {
       if (GetComponent<Animator>().GetBool("shooting") == true)
        {
            GetComponent<Animator>().SetBool("shooting", false);
        }
        else
        {
            GetComponent<Animator>().SetBool("shooting", true);
        }
    }
    
 
}

 