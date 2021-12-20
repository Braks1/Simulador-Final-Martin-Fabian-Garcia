using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    

    void Start()
    {

    }


   public void startGameF()
    {
        SceneManager.LoadScene("Gameplay");
    }



   public void quitGame()
    {
        Application.Quit();
    }

    

}
