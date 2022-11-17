using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{public GameObject projectilePrefab
  private float speed = 10.0;
  private float turnSpeed = 25.0f;
  private float horizontalInput;
  private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Moves the car forwards based on vertical input
    void Update()
    { // Rotates the car based on horizontal input
    horizontalInput = Input.GetAxis("Horizontal");
    forwardInput = Input.GetAxis("Vertical");   
    transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
    transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }
    
}
