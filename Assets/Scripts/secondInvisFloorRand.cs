using UnityEngine;

public class secondInvisFloorRand : MonoBehaviour
{
    //object with script
    public GameObject thingWithScript;
    private FirstInvisFloorRandomiser firstFloorScript;

    [SerializeField] public GameObject fourthPattern;
    [SerializeField] public GameObject fifthPattern;
    [SerializeField] public GameObject sixthPattern;

    //Initialiser for the random number
    private int randNum = 0;

    // Start is called before the first frame update
    void Start()
    {

        randNum = Random.Range(1, 4);
        firstFloorScript = thingWithScript.GetComponent<FirstInvisFloorRandomiser>();


    }

    private void OnTriggerEnter(Collider other)
    {
        firstFloorScript.firstPattern.SetActive(false);
        firstFloorScript.secondPattern.SetActive(false);
        firstFloorScript.thirdPattern.SetActive(false);

        switch (randNum)
        {
            case 1:
                fourthPattern.SetActive(true);
                break;
            case 2:
                fifthPattern.SetActive(true);
                break;
            case 3:
                sixthPattern.SetActive(true);
                break;

        }
    }

}
