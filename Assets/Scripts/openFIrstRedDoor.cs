using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openFIrstRedDoor : MonoBehaviour
{

    public GameObject door;
    public GameObject key;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(door);
        Destroy(key);
    }
}
