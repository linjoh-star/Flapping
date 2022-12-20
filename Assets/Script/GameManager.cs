using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{

    public GameObject column;


    void Start()
    {
        StartCoroutine(CreateColumn());
    }


    void Update()
    { 
    }

    IEnumerator CreateColumn(){
        yield return new WaitForSeconds((float) (Math.PI/3.0));

        GameObject new_column = Instantiate(column);
        new_column.transform.position = new Vector3(4, UnityEngine.Random.Range(-2f, 2f), 0);
        StartCoroutine(CreateColumn());
    }

}
