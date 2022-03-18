using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    //References
    public GameObject MainCam;
    public GameObject StartingSceneCam;
    private StartingScene StartingScene;

    void Start()
    {
        //References
        StartingScene = FindObjectOfType<StartingScene>();

        //Start Cam Location
        MainCam.transform.position = StartingSceneCam.transform.position;

        //Start
        Scenes();
    }

    void Scenes()
    {
        StartingScene.Main();
    }
}
