using UnityEngine;

public class unlockCamera : MonoBehaviour
{
    [SerializeField] GameObject blackCoverToDelete;


    //You can change the function if need be, but the theory behind unlocking the camera can stay the same.
    //So instead of OnTriggerEnter you can change to OnTriggerStay or something else.
    private void OnTriggerEnter(Collider other)
    {
        blackCoverToDelete.SetActive(false);
        
    }


}
