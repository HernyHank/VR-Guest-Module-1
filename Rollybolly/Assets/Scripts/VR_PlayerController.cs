using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class VR_PlayerController : MonoBehaviour
{

    public Rigidbody rb;

    public static int pickupCount = 0;

    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    public GameObject floor;

    public static int itemCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLLIDE");
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Transform[] allChildren = floor.GetComponentsInChildren<Transform>();
            foreach (Transform child in allChildren)
            {
                // Try to get the components on THIS specific child
                if (child.TryGetComponent<Collider>(out Collider col))
                {
                    col.enabled = false;
                }

                if (child.TryGetComponent<MeshRenderer>(out MeshRenderer ren))
                {
                    ren.enabled = false;
                }
            }
        }
    }

}

