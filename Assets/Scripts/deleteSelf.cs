using UnityEngine;

//This script is meant to destroy the gameObject you assign this script to

public class deleteSelf : MonoBehaviour
{

    [SerializeField] GameObject self;


    private void OnTriggerEnter(Collider other)
    {
        Destroy(self);
    }


}
