using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyUponArrowEnter : MonoBehaviour
{

    public GameObject scoreTextPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("projectile"))
        {
            this.gameObject.SetActive(false);
            other.gameObject.SetActive(false);
            VR_PlayerController.itemCount += 1;


            GameObject textObj = Instantiate(scoreTextPrefab, transform.position, Quaternion.identity);
            textObj.GetComponentInChildren<TextMeshPro>().text = VR_PlayerController.itemCount.ToString();
            if (Camera.main != null)
            {
                Vector3 headPos = Camera.main.transform.position;

                // This prevents the text from tilting up or down (keep it vertical)
                Vector3 lookAtPos = new Vector3(headPos.x, headPos.y, headPos.z);

                textObj.transform.LookAt(lookAtPos);
                textObj.transform.Rotate(0, 180, 0);
            }
            Destroy(textObj, 2.0f);

        }
    }
}
