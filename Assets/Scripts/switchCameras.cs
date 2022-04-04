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
    public Camera camSix;
    public Camera camSeven;
    public Camera camEight;
    //public Camera headCam;

    public List<Camera> cameras;
    public int i;
    public int sizeCheck;
    private int maxCameras;

    private void Start()
    {

        cameras.Add(camOne);
        cameras.Add(camTwo);
        cameras.Add(camThree);
        cameras.Add(camFour);
        cameras.Add(camFive);
        cameras.Add(camSix);
        cameras.Add(camSeven);
        cameras.Add(camEight);


        camOne.enabled = true;
        camTwo.enabled = false;
        camThree.enabled = false;
        camFour.enabled = false;
        camFive.enabled = false;
        camSix.enabled = false;
        camSeven.enabled = false;
        camEight.enabled = false;
        


        i = 0;
        maxCameras = cameras.Count;
        sizeCheck = i + 1;
    }

    
    public void addHeadCam(Camera headCam)
    {
        cameras.Add(headCam);
        headCam.enabled = false;
        maxCameras = cameras.Count;
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
         
        }

    }
}
