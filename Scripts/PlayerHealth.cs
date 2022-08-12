using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    private Rigidbody rb;
    private PlayerMovement playerScript;
    public int health = 10;
    private Transform enemy;

    [SerializeField] Transform spawn_point;
   // [SerializeField] TextMeshProUGUI texthealth;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerScript =GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        //texthealth.text = ("" + health);
        
        if (health <= 0)
        {
          SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex));
            Die();
        }
    }

    private void Die()
    {
        transform.position = spawn_point.position;
        health = 10;
    }
     
     private void Damage()
     {
       playerScript.enabled = false;

      rb.AddForce(Vector3.up * 250);

      if (transform.position.x < enemy.position.x)
          rb.AddForce(Vector3.right * -500);
          else
          rb.AddForce(Vector3.right * 500);

          Invoke("MoveAgain", 1);

     }
     private void MoveAgain()
    {
        playerScript.enabled = true;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") )
        {
            health--;
            enemy = collision.gameObject.transform;
            Damage();
        }
    }
    
}