using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text txt_points;
    int points = 0;
    public GameObject gameover_panel;
    public AudioClip lose;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 7);
            GetComponent<Animator>().Play("fly", 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Floor")
        {
            //Debug.Log("Game Over");
            Time.timeScale = 0;
            gameover_panel.SetActive(true);
            GetComponent<AudioSource>().PlayOneShot(lose);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Point")
        {
            Debug.Log("+1 POINT");
            points++;
            txt_points.text = points.ToString();
        }


    }
}