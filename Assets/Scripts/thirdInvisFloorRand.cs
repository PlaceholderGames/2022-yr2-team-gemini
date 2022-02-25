using UnityEngine;

public class thirdInvisFloorRand : MonoBehaviour
{
    //object with script
    public GameObject thingWithScript;
    private secondInvisFloorRand secondFloorScript;

    [SerializeField] public GameObject SeventhPattern;
    [SerializeField] public GameObject EigthPattern;
    [SerializeField] public GameObject NinthPattern;

    //Initialiser for the random number
    private int randNum = 0;

    // Start is called before the first frame update
    void Start()
    {

        randNum = Random.Range(1, 4);
        secondFloorScript = thingWithScript.GetComponent<secondInvisFloorRand>();


    }

    private void OnTriggerEnter(Collider other)
    {
        secondFloorScript.fourthPattern.SetActive(false);
        secondFloorScript.fifthPattern.SetActive(false);
        secondFloorScript.sixthPattern.SetActive(false);

        switch (randNum)
        {
            case 1:
                SeventhPattern.SetActive(true);
                break;
            case 2:
                EigthPattern.SetActive(true);
                break;
            case 3:
                NinthPattern.SetActive(true);
                break;

        }
    }

}
