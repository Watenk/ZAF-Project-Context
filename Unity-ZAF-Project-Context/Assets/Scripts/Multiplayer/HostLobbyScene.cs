using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Photon.Pun;

public class HostLobbyScene : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject onlyHostCanStartGame;
    void Start()
    {
        PhotonNetwork.Instantiate(playerPrefab.name, new Vector3(350, 210, -1), Quaternion.identity);
    }

    public void Main()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.LoadLevel("MainScene");
        }

        else
        {
            onlyHostCanStartGame.SetActive(true);
        }
    }
}
