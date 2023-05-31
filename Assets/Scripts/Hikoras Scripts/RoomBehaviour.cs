using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomBehaviour : MonoBehaviour
{
    public GameObject[] walls; // 0 = Up; 1 = Down; 2 = Righ; 3 = Left
    public GameObject[] doors;

    public void UpdateRoom(bool[] status)
    {
        for (int i = 0; i < status.Length; i++)
        {
            // True means the door is active, false means inactive.
            doors[i].SetActive(status[i]);
            // True means walls are inactive, false means they are active.
            walls[i].SetActive(!status[i]);
        }
    }
}
