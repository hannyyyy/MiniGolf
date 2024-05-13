using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class rotateCamera : MonoBehaviour
{
    public GameObject Camera;
    private Vector3 CameraPosition;
    public float Speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        CameraPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            transform.eulerAngles += Speed * new Vector3(x: -Input.GetAxis("Mouse Y"), y: Input.GetAxis("Mouse X"), z: 0);   
        }

        if (Input.GetKey(KeyCode.W))
        {
            CameraPosition.y += Speed / 10;     
        }

        if (Input.GetKey(KeyCode.S))
        {
            CameraPosition.y -= Speed / 10;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Camera.transform.position -= new Vector3(x: -1f*Time.deltaTime*Speed, y:0, z:0);
            Debug.Log("A pressed");
        }

        if (Input.GetKey(KeyCode.D))
        {
            CameraPosition.x += Speed / 10;
        }
    }
}
