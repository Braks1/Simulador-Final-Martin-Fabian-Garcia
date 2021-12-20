using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerScript : MonoBehaviour
{
    public Text contador;
    public bool startTimer;
    private float tiempo = 0f;
    public static int timeI { get; set; }

    // Update is called once per frame
    void Update()
    {
        if (startTimer == true)
        {
            if (tiempo >= 0)
            {
                tiempo += Time.deltaTime;
            }
            else
            {
                tiempo = 0;
            }

            DisplayTime(tiempo);

            timeI = (int)tiempo;
        }
        
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay > 0)
        {
            float minutes = Mathf.FloorToInt(timeToDisplay / 60);
            float seconds = Mathf.FloorToInt(timeToDisplay % 60);

            contador.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}
