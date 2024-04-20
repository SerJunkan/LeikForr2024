using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class spinthecoin : MonoBehaviour
{
    public float rotateSpeedx;
    public float rotateSpeedy;
    public float rotateSpeedz;

    private static int count = 0;// kannski commenta ut
    public TextMeshProUGUI countText;

    private void Start()
    {
        countText = GameObject.Find("Text3").GetComponent<TextMeshProUGUI>();
        //sprenging= GetComponent<Explosion>
        count = -1;
        SetCountText();
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject);
            gameObject.SetActive(false);
            Debug.Log("contact player");
            //count = count + 1;//færð stig
            //ScoreManager.instance.AddPoint();
            //Kassi.instance.SetCountText();
            SetCountText();//kallar í aðferðina
        }
    }

    private void SetCountText()//hér er aðferðin
    {
        count += 1;
        countText.text = "Money: " + count.ToString();
    }


        private void FixedUpdate()
    {
        transform.Rotate(rotateSpeedx, rotateSpeedy, rotateSpeedz);
    }

}


