using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    Renderer rederer;
    float rotationSpeed = 20.0f;
    float currentAngle = -90.0f;
    float minAngle = -90.0f;
    float maxAngle = 0.0f;
    bool clockwise = true;

    // Start is called before the first frame update
    void Start()
    {
        rederer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Time.deltaTime * rotationSpeed;

        if (currentAngle >= maxAngle)
        {
            clockwise = false;
        }
        else if(currentAngle <= minAngle) {
            clockwise = true;
        }
        if (clockwise)
        {
            currentAngle += angle;
        }
        else {
            currentAngle -= angle;

        }
        transform.rotation = Quaternion.Euler(0, currentAngle, 0);
    }
}
