using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject column;
    bool game_started = false;

    public GameObject start_panel;

    void Start()
    {
        Time.timeScale = 0;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && game_started == false)
        {
            Time.timeScale = 1;
            StartCoroutine(CreateColumn());
            game_started = true;

            start_panel.SetActive(false);
        }
    }

    IEnumerator CreateColumn()
    {
        yield return new WaitForSeconds((float)(Math.PI / 3.0));

        GameObject new_column = Instantiate(column);
        new_column.transform.position = new Vector3(4, UnityEngine.Random.Range(-2f, 2f), 0);
        StartCoroutine(CreateColumn());
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
