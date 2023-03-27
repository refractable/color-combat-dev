using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotateXScript : MonoBehaviour
{
    public float senstivity = 1f; 
    public Vector3 rotate;
    float x;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Mouse Y");
        rotate = new Vector3 (x * senstivity, 0);
        transform.eulerAngles = transform.eulerAngles - rotate;
    }
}
