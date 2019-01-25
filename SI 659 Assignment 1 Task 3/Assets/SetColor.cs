using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour {
	public GameObject wallL;
	public GameObject wallM;
	public GameObject wallR;
	public GameObject floor;

	// Use this for initialization
	void Start () {
		wallL.GetComponent<Renderer>().material.SetColor("_Color", new Color(152f/225f,166f/225f,200f/225f,1f));
		wallM.GetComponent<Renderer>().material.SetColor("_Color", new Color(152f/225f,166f/225f,200f/225f,1f));
		wallR.GetComponent<Renderer>().material.SetColor("_Color", new Color(152f/225f,166f/225f,200f/225f,1f));
		floor.GetComponent<Renderer>().material.SetColor("_Color", new Color(165f/225f,147f/225f,141f/225f,1f));
	}

	// Update is called once per frame
	void Update () {
		
	}
}
