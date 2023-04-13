using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class ReloadOnXButton : MonoBehaviour
{
    private InputDevice rightController;

    void Start()
    {
        // Find the right controller
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesAtXRNode(XRNode.LeftHand, devices);
        if (devices.Count > 0)
        {
            rightController = devices[0];
        }
    }

    void Update()
    {
        // Check if the X button is pressed down on the right controller
        if (rightController != null && rightController.TryGetFeatureValue(CommonUsages.primaryButton, out bool isPressed) && isPressed)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
