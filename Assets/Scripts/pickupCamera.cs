using UnityEngine;



public class pickupCamera : MonoBehaviour
{
    [SerializeField] GameObject pickupText;
    [SerializeField] GameObject cameraToMove;
    [SerializeField] GameObject modelCamToActivate;

    [SerializeField] GameObject objectWithScript;

    [SerializeField] Camera headCamToActivate;

    private void Start()
    {
        objectWithScript.GetComponent<switchCameras>();

        
    }


    private void OnTriggerStay(Collider other)
    {
        pickupText.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        pickupText.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            cameraToMove.SetActive(false);
            modelCamToActivate.SetActive(true);
            pickupText.SetActive(false);

            objectWithScript.GetComponent<switchCameras>().addHeadCam(headCamToActivate);
        }
    }

}
