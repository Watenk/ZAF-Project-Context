using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        //Toggle Fullscreen
        if (Input.GetKeyDown(KeyCode.F12))
        {
            Screen.fullScreen = !Screen.fullScreen;
        }
    }
}
