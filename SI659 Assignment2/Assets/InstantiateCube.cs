using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCube : MonoBehaviour {
    GameObject cube;
    Vector3 pos;
    // Use this for initialization
    void Start()
    {
        cube = GameObject.Find("ThrowableCube");
        pos = cube.transform.position;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ICube()
    {
        Instantiate(cube, pos, Quaternion.Euler(0, 0, 0));
    }
}
