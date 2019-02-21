using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour {
    public GameObject leftLight;
    public GameObject rightLight;
    private void OnTriggerEnter(Collider other)
    {
        leftLight.SetActive(true);
        rightLight.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        leftLight.SetActive(false);
        rightLight.SetActive(false);
    }
}
