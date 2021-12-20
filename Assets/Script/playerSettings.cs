using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace playerSettingsN
{
    public class playerSettings : MonoBehaviour
    {
        public static float speed;
        public static float speedResult;
        public float stamina;
        public static float weight { get; set; }
        public float jumpForce;
        public bool gameStarted = false;
        public bool winGame = false;
        public Animator anim;
        public Slider slider;
        public Text speedTextDisplay;
        public Text weightTextDisplay;
        public bool alive;


        void Start()
        {
            alive = true;
            weight = 1;
            speed = 1;
            stamina = 1000;
            slider.minValue = 0;
            slider.maxValue = 1000;


        }
        
        void Update()
        {

            if (alive == true)
            {
                speedResult = speed;
            }
            speedTextDisplay.text = "" + speed;
            weightTextDisplay.text = "" + weight;
            if (gameStarted == true)
            {
               
                transform.Translate(Vector3.forward  * speed * Time.deltaTime);      
                slider.value = stamina;
                stamina -= speed * weight * Time.deltaTime;

                
            }

        }

       


    }
}

