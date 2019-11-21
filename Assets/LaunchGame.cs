﻿using UnityEngine;
using System.Collections.Generic;

public class LaunchGame : MonoBehaviour
{
    public void HideUI()
    {
        Debug.Log("Test");
        GameObject mainUI = GameObject.Find("MainUI");
        mainUI.SetActive(false);
        GameObject fpsController = GameObject.Find("FPSController");
        (fpsController.GetComponent("FirstPersonController") as MonoBehaviour).enabled = true;
    }
}
