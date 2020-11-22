using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public bool gameOver;

    // Use this for initialization


    private void Awake()
    {
        if (instance == null)
        {

            instance = this;

        }
    }

    void Start () {
        FindObjectOfType<AudioManager>().PlaySound("atstart");
        gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void GameStart()
    {
        Invoke("StartInGameSound", .5f);
        UiManager.instance.GameStart();
        ScoreManager.instance.StartScore();
        // GameObject.Find("PlatformSpawner").GetComponent<PlatformSpawner>().StartSpawningPlatforms();
       
        PlatformSpawner.instance.StartSpawningPlatforms();
    }

    public void GameOver()
    {

        StopInGameSound();
        // FindObjectOfType<AudioManager>().PlaySound("ingame");
        //FindObjectOfType<AudioManager>().PlaySound("capsuleater");
        UiManager.instance.GameOver();
        ScoreManager.instance.StopScore();
        gameOver = true;
    }


    public void StartInGameSound()
    {
        FindObjectOfType<AudioManager>().PlaySound("ingame");


    }

    public void StopInGameSound()
    {
        FindObjectOfType<AudioManager>().StopSound("ingame");


    }


}
