using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUpdate : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateScoreText(ScoreManager scoreManager)
    {
        scoreText.text = scoreManager.Coins.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
