using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ChoiceScene : MonoBehaviour
{
    public GameObject MainCam;
    //public GameObject Choice1Cam;
    //public GameObject Choice2Cam;
    public GameObject playerPrefab;

    void Start()
    {
        PhotonNetwork.Instantiate(playerPrefab.name, new Vector3(0, -550, -50), Quaternion.identity);
    }


    void Update()
    {
        
    }
}
