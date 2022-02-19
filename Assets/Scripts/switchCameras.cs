using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class switchCameras : MonoBehaviour
{

    public GameObject camOne;
    public GameObject camTwo;
<<<<<<< Updated upstream
    private GameObject[] currentCam;
    public int iterator;
=======
    public GameObject camThree;
    public GameObject camFour;
    public List<GameObject> cameras;
    public int i;
    public int sizeCheck;
    private int maxCameras;
>>>>>>> Stashed changes

    private void Start()
    {
        camOne.SetActive(true);
<<<<<<< Updated upstream
        currentCam[0] = camOne;
        currentCam[1] = camTwo;
        iterator = 0;
=======
        cameras[0] = camOne;
        cameras[1] = camTwo;
        cameras[2] = camThree;
        cameras[3] = camFour;
        i = 0;
        maxCameras = cameras.Count;
        sizeCheck = i + 1;
>>>>>>> Stashed changes
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
