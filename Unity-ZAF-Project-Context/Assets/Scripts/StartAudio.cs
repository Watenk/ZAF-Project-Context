using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAudio : MonoBehaviour
{
    private AudioSource audioText;
    public Transform CamLocation;

    void Start()
    {
        audioText = GetComponent<AudioSource>();
    }

    void Update()
    {
        PlayAudio();
    }

    void PlayAudio()
    {
        if (CamLocation.GetComponentInChildren<Camera>() != null)
        {
            audioText.Play();
        }
    }
}
