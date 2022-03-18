using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class PlayerController : MonoBehaviour
{
    public float smoothTime = 100f;

    Vector3 movementChange;

    PhotonView view;

    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    void Update()
    {
        if (view.IsMine)
        {
            //Change in position
            movementChange = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);

            //Calc new Pos
            transform.position += movementChange;
        }
    }
}
