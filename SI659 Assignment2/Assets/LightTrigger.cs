using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour {
    public GameObject leftLight;
    public GameObject rightLight;
    public AudioSource audio;

    private void OnTriggerEnter(Collider other)
    {
        audio.Play();
        if (leftLight.activeSelf)
        {
            leftLight.SetActive(false);
            rightLight.SetActive(false);
        }
        else
        {
            leftLight.SetActive(true);
            rightLight.SetActive(true);
        }

    }
}
