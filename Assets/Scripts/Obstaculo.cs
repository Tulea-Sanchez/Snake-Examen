using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    

    [SerializeField]
    float ObstacleValue = 1.0F;

    [SerializeField]
    float lifeTime = 10.0F;


    bool isExpired = true;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
        
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
           
            isExpired = false;
            Destroy(gameObject);
        }
    }
}
