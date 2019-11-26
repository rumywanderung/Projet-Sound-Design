using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouLose : MonoBehaviour
{

    public PickUp O2;
    private AudioSource audioo;

    private void OnTriggerEnter(Collider other)
    {
        if (O2.o2 == false)
        {
            //GameObject GOUI = GameObject.Find("GameOver");
            //GOUI.SetActive(true);
            audioo = this.GetComponent<AudioSource>();
            audioo.Play();
        }
    }
    
      
}
