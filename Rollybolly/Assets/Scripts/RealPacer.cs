using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealPacer : MonoBehaviour
{
    // Start is called before the first frame updat

    private float direction = 1.0f;
    public float speed = 5.0f;
    private float adjustedSpeed;

    private float totalDistanceTraveled = 0f;

    private Vector3 previousPosition;

    void Start()
    {
        adjustedSpeed = speed / 100f;
        previousPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceThisFrame = Vector3.Distance(transform.position, previousPosition);
        totalDistanceTraveled += distanceThisFrame;
        previousPosition = transform.position;
        if (totalDistanceTraveled >= 15)
        {
            direction *= -1;
            totalDistanceTraveled = 0;
        }
        transform.Translate(new Vector3(adjustedSpeed*direction, 0, 0) * Time.deltaTime);
    }
}
