using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colectCoins : MonoBehaviour
{
    public static bool save;
    public Text scoreTxt;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        save = false;
        score = PlayerPrefs.GetInt("totalScore");
    }

    void Update()
    {
        scoreTxt.text = "Score " + score.ToString();
        saveScore();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("coin")==true)
        {
            score ++;
            Destroy(col.gameObject);
        }
    }
    private void saveScore()
    {
        if (save == true)
        {
            PlayerPrefs.SetInt("totalScore", score);
            PlayerPrefs.Save();
        }
    }
}
