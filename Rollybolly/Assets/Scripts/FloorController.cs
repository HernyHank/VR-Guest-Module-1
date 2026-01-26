using UnityEngine;

public class FloorController : MonoBehaviour
{
    public void MakeFloorDisappear()
    {
        // Disables the visual model
        GetComponent<MeshRenderer>().enabled = false;

        // Disables the physical surface so you fall through
        GetComponent<Collider>().enabled = false;

        // Optional: Destroy it after 2 seconds to clean up memory
        Destroy(gameObject, 1f);
    }
}
