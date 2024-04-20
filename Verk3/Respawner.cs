using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class Respawner : MonoBehaviour
{

    //public float timer = 0.0f;
    public int Showtime = 10;
    public float timeRemaining = 10;
    public TextMeshProUGUI Reser;


    // Start is called before the first frame update
    private void Start()
    {
        Reser = GameObject.Find("ResText").GetComponent<TextMeshProUGUI>();

        SetCountText();
    }

    /*  void Update()
      {
          timer += Time.deltaTime;
          int seconds = timer % 60;
      }*/

    void Update()
    {
        if (timeRemaining > 0)
        {
            SetCountText();
            timeRemaining -= Time.deltaTime;
            if (timeRemaining < Showtime) {
                Showtime -= 1; }
            //Showtime -= 1;
        }
        else
        {
            SceneManager.LoadScene(1); // loadar leik
        }
    }

    public void SetCountText()//hér er aðferðin
    {
    
        Reser.text = "You will respawn in: " + Showtime.ToString();
    }

}
