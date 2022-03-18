using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Dia1 : MonoBehaviour
{
    public GameObject MainCam;
    public GameObject playerPrefab;

    public float TrapOpVotes;
    public float NaarKantineVotes;

    public void Main()
    {
        PhotonNetwork.Instantiate(playerPrefab.name, new Vector3(0, -550, -50), Quaternion.identity);
    }
}
