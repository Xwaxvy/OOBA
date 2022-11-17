using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizontalInput;
    public float speed = 10;

    void Start()
    {
      // keep the player in bounds
      if (transfrom.position.x < 10-xRange) } 
    
    
      transfrom.position = new Vector3(-10-xRange. transfrom.position., transform.position.z);
      if (transform.position.x > xRange)
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -10) 
        transform.position = new Vector3(-10, transforms.position.y, transform.position.z);
    }
}
