using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void LateUpdate()
    {
        transform.position = target.position + offset;
        // Additional code to rotate camera with player, but seems to have a bug where camera is shown too low on the y-axis.
        // transform.LookAt(target, Vector3.up);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            offset.x -= 0.01f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            offset.x += 0.01f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            offset.z -= 0.01f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            offset.z += 0.01f;
        }
    }
}
