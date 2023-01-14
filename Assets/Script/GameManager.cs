using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class GameManager : MonoBehaviour
{
    public GameObject column;
    bool game_started = false;

    public GameObject start_panel;
    private const string SAVE_KEY = "save_key";
    public Player playerScript;
    public GameObject player;
    public Text highScoreText;

    void Start()
    {
        Time.timeScale = 0;
        Screen.SetResolution(540, 960, false);
        playerScript = player.GetComponent<Player>();
   

        string saveData = ReadString();
        highScoreText.text = saveData;
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

        ReadString();

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

        string saveData = ReadString();
        if (saveData != "" && saveData != null) {
            if (Int32.Parse(saveData) < playerScript.points) {
                WriteString(playerScript.points.ToString());
            }
            highScoreText.text = playerScript.points.ToString();
            
        }else {
            WriteString(playerScript.points.ToString());
            
        }
        SceneManager.LoadScene("Game");
    }

         public static void WriteString(string text)

       {

           string path = "./Assets/Script/test.txt";

           //Write some text to the test.txt file

           File.WriteAllText(path, text);

        }

       public static string ReadString()

       {

           if (File.Exists("./Assets/Script/test.txt"))
        {
            var fileContent = File.ReadAllText("./Assets/Script/test.txt");
            Debug.Log(fileContent);

            return fileContent;
        }

        return "";

       }
}
