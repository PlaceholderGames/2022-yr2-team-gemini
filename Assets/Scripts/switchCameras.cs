using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class switchCameras : MonoBehaviour
{

    public Camera camOne;
    public Camera camTwo;
    public Camera camThree;
    public Camera camFour;
    public Camera camFive;
    public List<Camera> cameras;
    public int i;
    public int sizeCheck;
    private int maxCameras;

    private void Start()
    {

        /*        cameras[0] = camOne;
                cameras[1] = camTwo;
                cameras[2] = camThree;
                cameras[3] = camFour;*/

        cameras.Add(camOne);
        cameras.Add(camTwo);
        cameras.Add(camThree);
        cameras.Add(camFour);
        cameras.Add(camFive);

        camOne.enabled = true;
        camTwo.enabled = false;
        camThree.enabled = false;
        camFour.enabled = false;
        camFive.enabled = false;


        i = 0;
        maxCameras = cameras.Count;
        sizeCheck = i + 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("camRight"))
        {
            cameras[i].enabled = false;

            if(sizeCheck < maxCameras)
            {
                i++;
                sizeCheck++;
            }

            cameras[i].enabled = true;

            //camOne.SetActive(false);
            //camTwo.SetActive(true);

        }

        if (Input.GetButtonDown("camLeft"))
        {
            cameras[i].enabled = false;

            if (sizeCheck-1 < 1)
            {
                i = 0;
                sizeCheck = 1;
            }
            else
            {
                i--;
                sizeCheck--;
            }


            cameras[i].enabled = true;

            //camOne.SetActive(true);
            //camTwo.SetActive(false);            
        }

    }
}
