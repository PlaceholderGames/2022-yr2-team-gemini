using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class switchCameras : MonoBehaviour
{

    public GameObject camOne;
    public GameObject camTwo;
    public List<GameObject> cameras;
    public int i;
    public int sizeCheck;
    private int maxCameras;

    private void Start()
    {
        camOne.SetActive(true);
        cameras[0] = camOne;
        cameras[1] = camTwo;
        i = 0;
        maxCameras = cameras.Count;
        sizeCheck = i + 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("camRight"))
        {
            cameras[i].SetActive(false);

            if(sizeCheck < maxCameras)
            {
                i++;
                sizeCheck++;
            }

            cameras[i].SetActive(true);

            //camOne.SetActive(false);
            //camTwo.SetActive(true);

        }

        if (Input.GetButtonDown("camLeft"))
        {
            cameras[i].SetActive(false);

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


            cameras[i].SetActive(true);

            //camOne.SetActive(true);
            //camTwo.SetActive(false);            
        }

    }
}
