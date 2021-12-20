using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using playerSettingsN;
using UnityEngine.SceneManagement;

public class victoryScript : MonoBehaviour
{
    public GameObject player;
    public playerSettings playerSettingsN;
    public gameplayScript gameplay;
    public timerScript timerScript;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(endTrial());

        }
    }

    IEnumerator endTrial()
    {
        gameplay.weightControlB.gameObject.SetActive(false);
        gameplay.speedControlB.gameObject.SetActive(false);
        playerSettingsN.alive = false;
        playerSettings.speed = 0;
        playerSettingsN.anim.SetBool("zeroSpeed", true);
        playerSettingsN.anim.SetBool("victory", true);
        timerScript.startTimer = false;
        yield return new WaitForSecondsRealtime(1);
        gameplay.endTrialText.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(5);
        gameplay.endtrialText2.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        gameplay.endtrialText2.text = "Dirigiendose a la pantalla de resultados";
        yield return new WaitForSecondsRealtime(0.5f);
        gameplay.endtrialText2.text = "Dirigiendose a la pantalla de resultados.";
        yield return new WaitForSecondsRealtime(0.5f);
        gameplay.endtrialText2.text = "Dirigiendose a la pantalla de resultados..";
        yield return new WaitForSecondsRealtime(0.5f);
        gameplay.endtrialText2.text = "Dirigiendose a la pantalla de resultados...";
        yield return new WaitForSecondsRealtime(1);
        SceneManager.LoadScene("Results");
    }
}
