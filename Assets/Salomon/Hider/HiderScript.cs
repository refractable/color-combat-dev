using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiderScript : MonoBehaviour
{
    public string hidePointTag = "HidePoint";

    private GameObject[] hidePoints;

    private void Start()
    {
        // Find all objects with the specified tag
        hidePoints = GameObject.FindGameObjectsWithTag(hidePointTag);

        // Generate a random index within the range of available hide points
        int randomIndex = Random.Range(0, hidePoints.Length);

        // Get the random hide point
        GameObject randomHidePoint = hidePoints[randomIndex];

        // Teleport the object to the random hide point's position
        transform.position = randomHidePoint.transform.position;
    }
}
