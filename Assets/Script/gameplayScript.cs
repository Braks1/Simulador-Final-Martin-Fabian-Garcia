using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using playerSettingsN;

public class gameplayScript : MonoBehaviour
{
    public float restV = 0.001f;
    
    public playerSettings playerSettings;
    public timerScript timerScript;
    public Text contadorTiempo;
    public Text endTrialText;
    public Text endtrialText2;
    public bool executeOnceEvent;
    public bool zeroSpeed;
    public bool gameOver;
    public Vector3 playerMovement;
    public GameObject weightControlB;
    public GameObject speedControlB;
    public Button btnIW;
    public Button btnDW;
    public Button btnIS;
    public Button btnDS;






    void Start()
    {
        gameOver = false;
        endTrialText.gameObject.SetActive(false);
        endtrialText2.gameObject.SetActive(false);
        timerScript.startTimer = false;
        playerSettings.gameStarted = false;
        contadorTiempo.text = "3";
        executeOnceEvent = true;
        playerSettings.anim.SetBool("gameStarted", false);
        playerSettings.anim.SetBool("zeroSpeed", false);
        playerSettings.anim.SetBool("noStamina", false);
        weightControlB.gameObject.SetActive(true);
        speedControlB.gameObject.SetActive(true);
        btnIW.enabled = false;
        btnDW.enabled = false;
        btnIS.enabled = false;
        btnIW.enabled = false;

    }

    void Update()
    {
        if (executeOnceEvent == true)
        {
            StartCoroutine(countdown());
        }
        if (playerSettings.speed <= 0 & gameOver == true)
        {
            playerSettings.speed = 0;
            playerSettings.stamina += restV;
            playerSettings.anim.SetBool("zeroSpeed", true);
        }
        if (playerSettings.speed <= 0)
        {
            playerSettings.speed = 0;
            playerSettings.anim.SetBool("zeroSpeed", true);
        }
        if (playerSettings.speed > 0)
        {
            playerSettings.anim.SetBool("zeroSpeed", false);
        }
        if (playerSettings.stamina <= 0)
        {
            StartCoroutine(endTrial());
            
        }

    }



    IEnumerator countdown()
    {
        executeOnceEvent = false;
        yield return new WaitForSeconds(1);
        contadorTiempo.text = "2";
        yield return new WaitForSeconds(1);
        contadorTiempo.text = "1";
        yield return new WaitForSeconds(1);
        contadorTiempo.text = "GO";
        yield return new WaitForSeconds(1);
        contadorTiempo.gameObject.SetActive(false);
        playerSettings.anim.SetBool("gameStarted", true);
        playerSettings.gameStarted = true;
        timerScript.startTimer = true;
        btnIW.enabled = true;
        btnDW.enabled = true;
        btnIS.enabled = true;
        btnIW.enabled = true;
    }

    IEnumerator endTrial()
    {
        weightControlB.gameObject.SetActive(false);
        speedControlB.gameObject.SetActive(false);
        playerSettings.alive = false;
        playerSettings.speed = 0;
        playerSettings.anim.SetBool("zeroSpeed", true);
        playerSettings.anim.SetBool("noStamina", true);
        timerScript.startTimer = false;
        yield return new WaitForSecondsRealtime(1);
        endTrialText.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(5);
        endtrialText2.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        endtrialText2.text = "Dirigiendose a la pantalla de resultados";
        yield return new WaitForSecondsRealtime(0.5f);
        endtrialText2.text = "Dirigiendose a la pantalla de resultados.";
        yield return new WaitForSecondsRealtime(0.5f);
        endtrialText2.text = "Dirigiendose a la pantalla de resultados..";
        yield return new WaitForSecondsRealtime(0.5f);
        endtrialText2.text = "Dirigiendose a la pantalla de resultados...";
        yield return new WaitForSecondsRealtime(1);
        SceneManager.LoadScene("Results");
    }

    


}
