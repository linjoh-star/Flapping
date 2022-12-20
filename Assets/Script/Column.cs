using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = transform.position - new Vector3(4 * Time.deltaTime, 0, 0);
        if (transform.position.x < -4) { 
            Destroy(transform.gameObject);
        }
        Debug.Log(transform.position.x);
    }
}   
