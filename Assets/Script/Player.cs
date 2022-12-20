using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 7);
            GetComponent<Animator>().Play("fly",0,0);
        }
    }
}