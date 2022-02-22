using UnityEngine;

public class FirstInvisFloorRandomiser : MonoBehaviour
{
    //Initialisers for the floor patterns
    [SerializeField] GameObject firstPattern;
    [SerializeField] GameObject secondPattern;
    [SerializeField] GameObject thirdPattern;

    //Initialiser for the random number
    int randNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        randNum = Random.Range(1, 4);
        pickPattern();
    }

    void pickPattern()
    {
        switch (randNum)
        {
            case 1:
                firstPattern.SetActive(true);
                break;
            case 2:
                secondPattern.SetActive(true);
                break;
            case 3:
                thirdPattern.SetActive(true);
                break;

        }
    }

}
