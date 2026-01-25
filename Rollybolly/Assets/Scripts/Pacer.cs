using UnityEngine;
using System.Collections;

public class Pacer : MonoBehaviour
{

    public float speed = 5.0f;
    private float xMax = -55f;
    private float xMin = -80f; //starting position

    private int direction = 1; //positive to start

    void Update()
    {
        float xNew = transform.position.x +
                     direction * speed * Time.deltaTime;
        if (xNew >= xMax)
        {
            xNew = xMax;
            direction *= -1;
        }
        else if (xNew <= xMin)
        {
            xNew = xMin;
            direction *= -1;
        }
        transform.position = new Vector3(xNew, 2f, 18f);
    }
}
