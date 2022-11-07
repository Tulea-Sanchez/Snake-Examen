using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    float moveSpeed = 5;
    float steerSpeed = 50;

    void Update()
    {
        //moverse hacia adelante
        transform.position += transform.forward * moveSpeed * Time.deltaTime;

        //girar
        float steerDirection = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * steerDirection * steerSpeed * Time.deltaTime);
    }
    
    
}
