using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleController : MonoBehaviour
{
    [SerializeField]
    CollectibleTypes collectibleType; 

    [SerializeField]
    float collectibleValue = 3.0F;

    [SerializeField]
    float lifeTime = 10.0F;

    [SerializeField]
    float expirationValue = -1.0F;

    bool isExpired = true;


    void Start() {
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
