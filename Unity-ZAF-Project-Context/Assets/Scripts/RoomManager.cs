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

    public Button GotoScene01Button;

    private void Start()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom("ZAFRoom");
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom("ZAFRoom");
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Intro");
    }

    public void GotoScene01()
    {
        PhotonNetwork.LoadLevel("Scene01");
    }
}
