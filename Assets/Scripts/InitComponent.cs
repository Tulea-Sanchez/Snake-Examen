using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        initComp();
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    IEnumerator initComp()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log(Time.deltaTime);
        //transform.gameObject.tag = "Fail";

    }
}
