using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 1f;

    public float xAxisRotate = 0;
    public float yAxisRotate = 0;
    public float zAxisRotate = 0;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(xAxisRotate, yAxisRotate, zAxisRotate) * speed * Time.deltaTime);
    }
}
