using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using playerSettingsN;

public class resultScript : MonoBehaviour
{
    public Text scoreText;
    public Text timeText;
    public Text speedText;
    public Text weightText;
    void Start()
    {
        scoreText.text = "";
        timeText.text = "";
        speedText.text = "";
        weightText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Conseguiste una puntuacion de: " + scorescript.scorePerformance.ToString();
        timeText.text = "La prueba duro un total de: " + timerScript.timeI.ToString() + "s";
        speedText.text = "Corriste a una velocidad de: " + playerSettings.speedResult.ToString() + " Mt/s";
        weightText.text = "Cargaste un peso total de: " + playerSettings.weight.ToString() + " KG";

    }
}
