using UnityEngine;

public class gunShoot : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;
    public int targetCounter = 0;
    [SerializeField] GameObject keyObject;

    public Camera fpsCam;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire"))
        {
            Shoot();
        }


    }

    void showKey()
    {
        keyObject.SetActive(true);
    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            if(hit.transform.name == "target")
            {
                targetCounter += 1;
                Destroy(hit.transform.gameObject);

                if (targetCounter == 7)
                {
                    showKey();
                }
            }
            Debug.Log(hit.transform);
        }
    }
}
