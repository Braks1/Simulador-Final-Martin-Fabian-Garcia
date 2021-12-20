using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using playerSettingsN;

public class bridgeScript : MonoBehaviour
{
    public GameObject player;
    public playerSettings playerSettingss;
    public gameplayScript gameplay;
    public cameraScript scriptC;
    public timerScript timerScript;
    public HingeJoint joint;
    public HingeJoint joint2;
    public Camera cameraa;


    void Start()
    {
        joint.gameObject.SetActive(true);
        joint2.gameObject.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            int valor = (int)playerSettings.weight;
            if (valor >= 7)
            {
                joint.gameObject.SetActive(false);
                joint2.gameObject.SetActive(false);
                scriptC.enabled = false;
                StartCoroutine(failScript());

            }
            else
            {
                return;
            }

        }
      
    }
    IEnumerator failScript()
    {
        yield return new WaitForSecondsRealtime(0.3f);
        gameplay.weightControlB.gameObject.SetActive(false);
        gameplay.speedControlB.gameObject.SetActive(false);
        playerSettingss.alive = false;
        playerSettings.speed = 0;
        playerSettingss.anim.SetTrigger("falling");
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
