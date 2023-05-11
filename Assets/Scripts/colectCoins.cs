using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colectCoins : MonoBehaviour
{
    public Text scoreTxt;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    void Update()
    {
        scoreTxt.text = "Score " + score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("coin")==true)
        {
            score ++;
            Destroy(col.gameObject);
        }
    }
}
