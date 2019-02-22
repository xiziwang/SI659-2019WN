using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBall : MonoBehaviour {
    GameObject ball;
    Vector3 pos;
	// Use this for initialization
	void Start () {
        ball = GameObject.Find("ThrowableBall");
        pos = ball.transform.position;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void IBall()
    {
        Instantiate(ball, pos, Quaternion.Euler(0,0,0));
    }
}
