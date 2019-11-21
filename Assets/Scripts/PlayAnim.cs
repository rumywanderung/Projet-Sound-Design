using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayAnim : MonoBehaviour
{
    private bool animStarted = false;
    private float duration = 0;
    
    void Awake()
    {
        GetComponent<PlayableDirector>().Stop();
        GetComponent<AudioSource>().Stop();
    }

   
    void Update()
    {
        if (Input.GetKeyUp("g"))
        {
            Debug.Log("LANDING");
            GetComponent<PlayableDirector>().Play();
            GetComponent<AudioSource>().Play();
            animStarted = true;
        }
        if (animStarted)
        {
            
            if (duration < 25.08F)
            {
                Debug.Log(duration);
                duration += Time.deltaTime;
            }
            if (duration >= 25.08F)
            {
                Debug.Log(duration);
                GetComponent<AudioSource>().Stop();
                animStarted = false;

                //spaceship becomes clickable

            }
        }
        
    }
}
