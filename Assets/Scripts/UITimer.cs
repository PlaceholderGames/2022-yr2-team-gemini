using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UITimer : MonoBehaviour
{
	public TMP_Text TimerText;
	public bool playing;
	private float Timer;

    private void Start()
    {
		//1 = 1 second
		//600 = 10 minutes
		Timer = 600;
    }

    void Update()
	{

		if (playing == true)
		{

			Timer -= Time.deltaTime;
			int minutes = Mathf.FloorToInt(Timer / 60F);
			int seconds = Mathf.FloorToInt(Timer % 60F);
			int milliseconds = Mathf.FloorToInt((Timer * 100F) % 100F);
			TimerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
		}

		if(Timer <= 0)
        {
			SceneManager.LoadScene("LoseScene");
        }

	}

}