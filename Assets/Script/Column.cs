using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    float offset;
    void Start()
    {
        offset = Random.Range(0, 1.8f  * Mathf.PI);
    }


    void FixedUpdate()
    {
        transform.position = transform.position - new Vector3(0.1f, 0, 0);
        if (transform.position.x < -4)
        {
            Destroy(transform.gameObject);
        }
        
        transform.position = transform.position + (Vector3.up * Mathf.Cos(Time.time * 2f + offset) / 40);


        //Debug.Log(transform.position.x);
    }
}
