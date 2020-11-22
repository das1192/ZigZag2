using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {


    public static ScoreManager instance;

    public bool bonus;
    public int score;
    public int highScore;


    private void Awake()
    {
        if(instance== null)
        {

            instance = this;
        }
    }

    // Use this for initialization
    void Start () {

        score = 0;
        PlayerPrefs.SetInt("score", score);

	}


    void IncrementScore()
    {
        if (bonus == true)
        {
            score = score + 1;
            score = score + 5;
        }
        else
        {
            score = score + 1;
        }
        PlayerPrefs.SetInt("runningScore", score);
        UiManager.instance.RunningSocre();
        bonus = false;
    }


    public void Bonus()
    {


        bonus = true;


    }
    public void StartScore()
    {

        InvokeRepeating("IncrementScore", 0.1f, 0.5f);


    }
	
    public void StopScore()
    {
        CancelInvoke("IncrementScore");
        PlayerPrefs.SetInt("score", score);


        if (PlayerPrefs.HasKey("highScore")) {

            if (score > PlayerPrefs.GetInt("highScore"))
            {

                PlayerPrefs.SetInt("highScore", score);
            }



        }
        else
        {
            PlayerPrefs.SetInt("highScore", score);

        }


    }

	// Update is called once per frame
	void Update () {
	
	}
}
