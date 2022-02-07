using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class switchCameras : MonoBehaviour
{

    public GameObject camOne;
    public GameObject camTwo;
    private GameObject[] currentCam;
    public int iterator;

    private void Start()
    {
        camOne.SetActive(true);
        currentCam[0] = camOne;
        currentCam[1] = camTwo;
        iterator = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("camRight"))
        {
            camOne.SetActive(false);
            camTwo.SetActive(true);

        }

        if (Input.GetButtonDown("camLeft"))
        {
            camOne.SetActive(true);
            camTwo.SetActive(false);            
        }

    }
}
