using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingScene : MonoBehaviour
{
    public GameObject MainCam;
    public GameObject ChoiceCam;

    public bool ScriptEnabled = false;

    float Timer = 5f;

    void Start()
    {

    }

    void Update()
    {
        if (Timer >= 0f && ScriptEnabled == true)
        {
            Timer -= Time.deltaTime;
        }

        if (Timer <= 0f)
        {
            MainCam.transform.position = ChoiceCam.transform.position;
            ScriptEnabled = false;
        }
    }

    public void Main()
    {
        ScriptEnabled = true;
    }
}
