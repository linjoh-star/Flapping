using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnScript : MonoBehaviour
{
    public GameObject go;
    void Start()
    {
        
    }


    void Update()
    {
        if (transform.position.x < -4 ) {
            Destroy(go); 
        }
        Debug.Log(go.transform.position.x);

    }
}
