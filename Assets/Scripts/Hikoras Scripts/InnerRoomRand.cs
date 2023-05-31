using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerRoomRand : MonoBehaviour
{
    // As reference: 0, up, 1 down, 2 right, 3 left
    public GameObject[] walls;
    public GameObject[] doors;
    public bool[] testStatus;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomDoorGen(bool[] status)
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
