using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwards : MonoBehaviour
{
    public float speed = 40.0f;

    void Start()
    {
        
    }
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.space))
        transform.Translate(Vector3.forwards * Time.DeltaTime * speed);
    }
}
