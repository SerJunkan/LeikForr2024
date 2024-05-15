using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GemManager : MonoBehaviour
{
    public int healthCount;
    public TextMeshProUGUI healthText;

    public int gemCount;
    public TextMeshProUGUI gemText;
    // Start is called before the first frame update
    void Start()
    {
        healthCount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        gemText.text = gemCount.ToString();

        healthText.text = healthCount.ToString();

        if (healthCount == 0)
        {
            SceneManager.LoadScene(4);
        }

        if (gemCount == 12)
        {
            SceneManager.LoadScene(5);

        }
    }
}
