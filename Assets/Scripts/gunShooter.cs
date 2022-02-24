using UnityEngine;

public class gunShooter : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;
    public int TargetCounter = 0;
    [SerializeField] GameObject key;

    public Camera fpsCam;

    private void Update()
    {

        if (Input.GetButtonDown("Fire"))
        {
            Shoot();
        }

        if (TargetCounter == 7)
        {
            key.SetActive(true);
        }


    }

    void Shoot()
    {
        RaycastHit hit;

        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            if(hit.transform.name == "target")
            {
                TargetCounter += 1;
                Destroy(hit.transform.gameObject);

            }
        }
    }


}
