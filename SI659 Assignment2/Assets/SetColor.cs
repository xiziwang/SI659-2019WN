using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour {
	public GameObject wallL1;
    public GameObject wallL2;
    public GameObject wallL3;

    public GameObject wallM1;
    public GameObject wallM2;
    public GameObject wallM3;
    public GameObject wallM4;

    public GameObject wallR1;
    public GameObject wallR2;
    public GameObject wallR3;

    public GameObject celling;

    //public GameObject floor;

    // Use this for initialization
    void Start () {
		wallL1.GetComponent<Renderer>().material.SetColor("_Color", new Color(152f/225f,166f/225f,200f/225f,1f));
        wallL2.GetComponent<Renderer>().material.SetColor("_Color", new Color(152f / 225f, 166f / 225f, 200f / 225f, 1f));
        wallL3.GetComponent<Renderer>().material.SetColor("_Color", new Color(152f / 225f, 166f / 225f, 200f / 225f, 1f));

        wallM1.GetComponent<Renderer>().material.SetColor("_Color", new Color(152f/225f,166f/225f,200f/225f,1f));
        wallM2.GetComponent<Renderer>().material.SetColor("_Color", new Color(152f / 225f, 166f / 225f, 200f / 225f, 1f));
        wallM3.GetComponent<Renderer>().material.SetColor("_Color", new Color(152f / 225f, 166f / 225f, 200f / 225f, 1f));
        wallM4.GetComponent<Renderer>().material.SetColor("_Color", new Color(152f / 225f, 166f / 225f, 200f / 225f, 1f));

        wallR1.GetComponent<Renderer>().material.SetColor("_Color", new Color(152f/225f,166f/225f,200f/225f,1f));
        wallR2.GetComponent<Renderer>().material.SetColor("_Color", new Color(152f / 225f, 166f / 225f, 200f / 225f, 1f));
        wallR3.GetComponent<Renderer>().material.SetColor("_Color", new Color(152f / 225f, 166f / 225f, 200f / 225f, 1f));

        celling.GetComponent<Renderer>().material.SetColor("_Color", new Color(152f / 225f, 166f / 225f, 200f / 225f, 1f));


        //floor.GetComponent<Renderer>().material.SetColor("_Color", new Color(165f/225f,147f/225f,141f/225f,1f));
    }

    // Update is called once per frame
    void Update () {
		
	}
}
