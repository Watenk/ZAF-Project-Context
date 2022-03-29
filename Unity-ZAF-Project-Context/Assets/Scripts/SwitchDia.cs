using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchDia : MonoBehaviour
{
    public List<GameObject> CamLocations;
    public List<AudioSource> AudioClips;
    public List<Slider> Sliders;
    bool startTimer = false;
    float timerAmount = 55f;
    public Camera cam;
    private int diaCounter = 0;

    private void Start()
    {
        set();
    }

    public void NextDia()
    {
        Debug.Log("Pressed");
        diaCounter += 1;
        set();
    }

    public void set()
    {
        cam.transform.position = CamLocations[diaCounter].transform.position;
        cam.transform.parent = CamLocations[diaCounter].transform;
        AudioClips[diaCounter - 1].Stop();
        AudioClips[diaCounter].Play();
        startTimer = true;
        timerAmount = 55f;
    }

    private void Update()
    {
        if (startTimer == true)
        {
            timerAmount -= Time.deltaTime;
        }

        if (timerAmount <= 0f)
        {
            startTimer = false;
        }

        Sliders[diaCounter - 1].value = timerAmount;
    }
}
