using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using playerSettingsN;

public class scorescript : MonoBehaviour
{
    public float increase = 1f;
    public static int scorePerformance { get; set; }
    public playerSettings playerSettings;
    public Text scoreText;
    
    void Start()
    {
        scorePerformance = 0;
        scoreText.text = "0";
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerSettings.gameStarted == true)
        {

            scorePerformance += (int)increase * (int)playerSettings.speed;
            scoreText.text = scorePerformance.ToString();
        }
    }
}
