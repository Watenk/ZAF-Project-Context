using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingScene : MonoBehaviour
{
    public GameObject MainCam;
    public GameObject ChoiceCam;
    private Dia1 dia1;

    public bool ScriptEnabled = false;

    float Timer = 5f;

    void Start()
    {
        dia1 = FindObjectOfType<Dia1>();
    }

    void Update()
    {
        if (Timer >= 0f && ScriptEnabled == true)
        {
            Timer -= Time.deltaTime;
        }

        if (Timer <= 0f)
        {
            if (ScriptEnabled == true)
            {
                MainCam.transform.position = ChoiceCam.transform.position;
                dia1.Main();
            }
            ScriptEnabled = false;
        }
    }

    public void Main()
    {
        ScriptEnabled = true;
    }
}
