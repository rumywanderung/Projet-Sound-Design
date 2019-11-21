using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayAnim : MonoBehaviour
{
    
    
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
        }
        
    }
}
