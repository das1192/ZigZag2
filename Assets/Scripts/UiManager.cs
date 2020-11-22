using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UiManager : MonoBehaviour {


    public GameObject zigZagPanel;
    public GameObject gameOverPanel;
    public GameObject tapText;
    public Text score;
    public Text runningScore;
    public Text highScore1;
    public Text highScore2;


    public static UiManager instance;


    public void Awake()
    {
        
        if(instance== null)
        {

            instance = this;
        }


    }

    // Use this for initialization
    void Start () {
        highScore1.text ="High Score :" + PlayerPrefs.GetInt("highScore").ToString();

	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void RunningSocre()
    {
       runningScore.text = "Score : " + PlayerPrefs.GetInt("runningScore").ToString();



    }

    public void GameStart()
    {

        runningScore.gameObject.SetActive(true) ;
        //tapText.SetActive(false);
        tapText.GetComponent<Animator>().Play("textdown");
        zigZagPanel.GetComponent<Animator>().Play("panelUp");
        tapText.GetComponent<Animator>().Play("textdown");

    }


    public void GameOver()
    {
        runningScore.gameObject.SetActive(true);
        score.text =  PlayerPrefs.GetInt("score").ToString();
        highScore2.text = PlayerPrefs.GetInt("highScore").ToString();

        gameOverPanel.SetActive(true);

    }


    public  void Restart()
    {

        SceneManager.LoadScene(0);


    }
}
