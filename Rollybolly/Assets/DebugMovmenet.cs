using UnityEngine;
using Valve.VR;

public class VRDebugInput : MonoBehaviour
{
    // 1. Make sure these are assigned in the Inspector!
    public SteamVR_Input_Sources handType = SteamVR_Input_Sources.LeftHand;
    public SteamVR_Action_Vector2 moveAction;

    void Update()
    {
        // Check if the action is actually "connected"
        if (moveAction.GetActive(handType))
        {
            Vector2 value = moveAction.GetAxis(handType);
            Debug.Log($"<color=green>JOYSTICK:</color> X: {value.x:F2} | Y: {value.y:F2}");
        }
        else
        {
            // If this prints, SteamVR doesn't think the action exists for this hand
            Debug.LogWarning("Action not active. Check Action Sets or Bindings.");
        }
    }
}
