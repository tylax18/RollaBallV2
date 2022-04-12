using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;

    private Rigidbody rb;
   // public float minHeightForDeath = -10.0f;
    public Vector3 startPosition;
    //public Transform spawnPoint;
    //public GameObject player;
    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition =transform.position;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);



        if(transform.position.y < -5){
            transform.position = startPosition;
            rb.velocity = new Vector3(0,0,0);
           // rb.rotation = Vector3.zero;
        
        }
    }

//     void OnTriggerEnter(Collider other)
//     {
//         if (other.gameObject.CompareTag("Pick Up"))
//         {
//             other.gameObject.SetActive(false);
//         }
//     }
   }
