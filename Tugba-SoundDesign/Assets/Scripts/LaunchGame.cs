using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class LaunchGame : MonoBehaviour
{
    public GameObject textDisplay;
    public ShipWin ship;

    public int SecondsLeft = 30;
    public bool takingAway = false;

    private AudioSource sonAmbience;
    private AudioClip clip;
    
    private void Awake()
    {
        sonAmbience = GetComponent<AudioSource>();
        sonAmbience.Play();
    }
    //HideMainUI
    public void HideUI()
    {
        Debug.Log("Test");
        GameObject mainUI = GameObject.Find("MainUI");
        mainUI.SetActive(false);
        GameObject fpsController = GameObject.Find("FPSController");
        (fpsController.GetComponent("FirstPersonController") as MonoBehaviour).enabled = true;

        takingAway = true;
        textDisplay.GetComponent<Text>().text = "00:" + SecondsLeft;

        sonAmbience.clip = Resources.Load<AudioClip>("Alarmm2");
        sonAmbience.Play();
        //alarm moins fort
    }
    void Update()
    {
        if (takingAway == true && SecondsLeft >= 0)
        {
            StartCoroutine(TimeTake());
        }
    }

    //Coroutine
    IEnumerator TimeTake()
    {
        takingAway = false;
        yield return new WaitForSeconds(1);
        SecondsLeft -= 1;

        if (SecondsLeft < 10)
        {
            textDisplay.GetComponent<Text>().text = "00:0" + SecondsLeft;

            if (SecondsLeft == 0){

                if (ship.won == true) {

                    GameObject YWUI = GameObject.Find("YouWin");
                    YWUI.SetActive(true);
                }

                else if (ship.won == false)
                {
                    GameObject GOUI = GameObject.Find("GameOver");
                    GOUI.SetActive(true);
                }
            }
        }
        else
        {
            textDisplay.GetComponent<Text>().text = "00:" + SecondsLeft;
        }
        takingAway = true;
    }
    
}
