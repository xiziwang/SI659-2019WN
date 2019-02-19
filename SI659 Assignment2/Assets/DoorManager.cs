using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour {
    public GameObject player;
    Vector3 playerLocation;

    Renderer rederer;
    float rotationSpeed = 40.0f;
    float currentAngle = -90.0f;
    float minAngle = -90.0f;
    float maxAngle = 0.0f;
    bool isOpening = false;
    bool isClosing = true;

    public AudioSource doorAudio;

    // Start is called before the first frame update
    void Start()
    {
        rederer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        GetPlayerLocation();
        DoorListener();
    }

    void GetPlayerLocation()
    {
        playerLocation = player.transform.position;
    }

    void DoorListener()
    {
        // if the user is in front of the door
        if(playerLocation.x>=0 && playerLocation.x <=10 && playerLocation.z<=-12 && playerLocation.z >= -17)
        {
            if (!isOpening)
            {
                doorAudio.Play();
            }
            OpenDoor();
        }
        else
        {
            if (!isClosing)
            {
                doorAudio.Play();
            }
            CloseDoor();
        }
    }

    void OpenDoor()
    {
        float angle = Time.deltaTime * rotationSpeed;

        if (currentAngle <= maxAngle)
        {
            currentAngle += angle;
            transform.rotation = Quaternion.Euler(0, currentAngle, 0);
        }
        isOpening = true;
        isClosing = false;
    }

    void CloseDoor()
    {
        float angle = Time.deltaTime * rotationSpeed;

        if (currentAngle >= minAngle)
        {
            currentAngle -= angle;
            transform.rotation = Quaternion.Euler(0, currentAngle, 0);
        }
        isClosing = true;
        isOpening = false;
    }
}
