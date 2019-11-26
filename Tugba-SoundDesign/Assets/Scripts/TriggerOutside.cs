using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOutside : MonoBehaviour
{
    public GameObject manager;
    private AudioSource Audio;
    private AudioSource Audio2 = new AudioSource();

    public bool audioOutSide = false;
    private AudioClip clip;

    private void Start()
    {
        Audio = manager.GetComponent<AudioSource>();
        Audio.volume = 2f;
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "FPSController")
        {
            if (audioOutSide == false)
            {
                audioOutSide = true;

                Audio.volume = 0.2f;

                Debug.Log(audioOutSide);
                Debug.Log(Audio.volume);

                Audio.clip = Resources.Load<AudioClip>("Alarmm2");
                Audio.Play();

                Audio2 = this.gameObject.AddComponent<AudioSource>();
                Audio2.clip = Resources.Load<AudioClip>("outside");
                Audio2.Play();

                return;

                //audioOutSide = false;
            }

            else if (audioOutSide == true)
            {
                audioOutSide = false;

                Audio2.Stop();

                Debug.Log(audioOutSide);

                Audio.clip = Resources.Load<AudioClip>("Alarmm2");
                Audio.volume = 2f;
                Audio.Play();

                return;
            }
        }
    }
    
}
