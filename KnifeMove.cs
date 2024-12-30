using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeMove : MonoBehaviour
{
    void Update()
    {
        float y = Input.GetAxis("Vertical") * 0.1f;
        float z = Input.GetAxis("Horizontal") * 0.1f;
        transform.Translate(0, y, z);

        float yr = Input.GetAxis("Mouse X") * 3f;
        float zr = Input.GetAxis("Mouse ScrollWheel") * 30f;
        transform.Rotate(0, yr, zr);

        if (Input.GetMouseButton(0))
        {
            zr -= 1.5f;
            transform.Rotate(0, 0, zr);
        }        
    }
}
