using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Rest : MonoBehaviour
{
    public TextMeshProUGUI Finalskor;
    void Start()
    {
        Finalskor.text = ("Score = "+Hareket.skor);
    }
    void Update()
    {
            if(Input.anyKeyDown)
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Print))
                {
                    return;
                }

            if(Input.GetKeyDown(KeyCode.Escape))
       {
          Application.Quit();
       }
       SceneManager.LoadScene("Oyun");
        }
    }
}
