using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class PlayerController : MonoBehaviour
{
    public float speed = 100f;

    Vector3 movementChange;

    Dia1 dia1;

    PhotonView view;

    void Start()
    {
        view = GetComponent<PhotonView>();
        dia1 = FindObjectOfType<Dia1>();
    }

    void Update()
    {
        if (view.IsMine)
        {
            //Change in position
            movementChange = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);

            //Calc new Pos
            transform.position += movementChange * Time.deltaTime * speed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Dia 1
        if (collision.CompareTag("Dia1A"))
        {
            dia1.TrapOpVotes += 1f;
        }

        if (collision.CompareTag("Dia1B"))
        {
            dia1.NaarKantineVotes += 1f;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Dia 1
        if (collision.CompareTag("Dia1A"))
        {
            dia1.TrapOpVotes -= 1f;
        }

        if (collision.CompareTag("Dia1B"))
        {
            dia1.NaarKantineVotes -= 1f;
        }
    }
}
