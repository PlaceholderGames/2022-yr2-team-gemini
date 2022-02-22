using UnityEngine;

public class gunShooter : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;

    private void Update()
    {

        if (Input.GetButtonDown("Fire"))
        {
            Shoot();
        }


    }

    void Shoot()
    {
        RaycastHit hit;

        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            if(hit.transform.name == "target")
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }


}
