using UnityEngine;
using System.Collections;

public class TriggerChecker : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerExit(Collider ball)
    {
        if(ball.gameObject.tag == "Ball")
        {
            Invoke("Falldown", .5f);
        }
        
    }

    


    void Falldown()
    {

        GetComponentInParent<Rigidbody>().useGravity = true;
        GetComponentInParent<Rigidbody>().isKinematic = false;
        Destroy(transform.parent.gameObject, 2f);


    }


}
