using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Kassi : MonoBehaviour
{

    public static Kassi instance;

    public static int count=0;
    public GameObject sprenging;
    public TextMeshProUGUI countText;
    void Start()
    {
        countText = GameObject.Find("Text").GetComponent<TextMeshProUGUI>();
        //sprenging= GetComponent<Explosion>
        count = -1;
        SetCountText();
    }
    private void Update()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "kula")
        {
            Destroy(gameObject);
            gameObject.SetActive(false);
            Debug.Log("varð fyrir kúlu");
            //count = count + 1;//færð stig
            //ScoreManager.instance.AddPoint();
            SetCountText();//kallar í aðferðina
            Sprengin();
        }
    }
    public void SetCountText()//hér er aðferðin
    {
        count += 1;
        countText.text = "Points: " + count.ToString();
    }
    void Sprengin()
    {
        Instantiate(sprenging, transform.position, transform.rotation);
    }
}
