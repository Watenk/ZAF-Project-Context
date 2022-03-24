using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDia : MonoBehaviour
{
    public List<GameObject> CamLocations;
    public Camera cam;
    private int diaCounter = 0;

    private void Start()
    {
        cam.transform.position = CamLocations[diaCounter].transform.position;
    }

    public void NextDia()
    {
        Debug.Log("Pressed");
        diaCounter += 1;
        cam.transform.position = CamLocations[diaCounter].transform.position;
    }
}
