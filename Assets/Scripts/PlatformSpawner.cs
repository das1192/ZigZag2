using UnityEngine;
using System.Collections;

public class PlatformSpawner : MonoBehaviour {


    public static PlatformSpawner instance;

    Vector3 lastpos;
    public GameObject platform;
    public GameObject capsule;
    float size;
    public bool GameOver;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start () {
       
        lastpos = platform.transform.position;
        size = platform.transform.localScale.x;
        for (int i = 0;i<20; i++)
        {
            SpawnPlatforms();

        }


	}


    public void StartSpawningPlatforms()
    {

        InvokeRepeating("SpawnPlatforms", 0.1f, 0.2f);


    }
	
	// Update is called once per frame
	void Update () {

        if (GameManager.instance.gameOver == true) {
            CancelInvoke("SpawnPlatforms");

           }
       }

    void SpawnPlatforms()
    {

        int ran = Random.Range(0, 6);


        if (ran > 3)
        {
            SpawnX();
        }
        else
        {
            SpawnZ();
        }


    }

    void SpawnX()
    {
        Vector3 pos = lastpos;
        pos.x += size;
        lastpos = pos;

        Instantiate(platform, pos, Quaternion.identity);

        int ran = Random.Range(0, 6);


        if (ran < 1)
        {
            Instantiate(capsule,new Vector3(pos.x,pos.y+1,pos.z), Quaternion.identity);
        }



    }




    void SpawnZ()
    {
        Vector3 pos = lastpos;
        pos.z += size;
        lastpos = pos;

        Instantiate(platform, pos, Quaternion.identity);

        int ran = Random.Range(0, 5);


        if (ran < 1)
        {
            Instantiate(capsule, new Vector3(pos.x, pos.y + 1, pos.z), Quaternion.identity);
        }




    }
}
