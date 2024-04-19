using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCamera : MonoBehaviour
{
    public float Speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            transform.eulerAngles += Speed * new Vector3(x: -Input.GetAxis("Mouse Y"), y: Input.GetAxis("Mouse X"), z: 0);
        }
    }
}
