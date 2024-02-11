using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class ScoreManager : MonoBehaviour
{
    int score;

    public TextMeshProUGUI ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        ScoreText.text = score.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {

        if(other.gameObject.name == "Player") {
            score = Int32.Parse(ScoreText.text);
            score += 1;
            ScoreText.text = score.ToString();
            transform.position = new Vector3(transform.position.x, -10, transform.position.z);
        }
       
    }
}
