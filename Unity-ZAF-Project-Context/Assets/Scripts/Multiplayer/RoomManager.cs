using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class RoomManager : MonoBehaviourPunCallbacks
{
    //PhotonView.RPC

    public Button hostButton;
    public Button joinButton;

    public GameObject gameAlreadyStarted;
    public GameObject gameAlreadyHosted;
    public GameObject loading;

    float hostTimer = 3f;
    bool startHostTimer = false;

    private void Start()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    private void Update()
    {
        //Timer Update
        if (startHostTimer == true && hostTimer >= 0f)
        {
            hostTimer -= Time.deltaTime;
        }

        if (hostTimer <= 0f)
        {
            loading.SetActive(false);
            gameAlreadyHosted.SetActive(true);
        }
    }

    public void CreateRoom()
    {
        startHostTimer = true;
        loading.SetActive(true);
        PhotonNetwork.CreateRoom("ZAFRoom");
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom("ZAFRoom");
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("HostLobby");
    }
}
