using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using playerSettingsN;
using UnityEngine.SceneManagement;

public class buttonsScripts : MonoBehaviour
{
    public playerSettings playerSettings;


    public void increaseButtonW()
    {
        playerSettings.weight += 1;
        if (playerSettings.weight >= 15)
        {
            playerSettings.weight = 15;
        }
    }

    public void decreaseButtonW()
    {
        playerSettings.weight -= 1;
        if (playerSettings.weight <= 1)
        {
            playerSettings.weight = 1;
        }
    }


    public void increaseSpeedW()
    {
        playerSettings.speed += 1;
        if (playerSettings.speed >= 10)
        {
            playerSettings.speed = 10;
        }
    }


    public void decreaseSpeedW()
    {
        playerSettings.speed -= 1;
    }

    public void continueToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
