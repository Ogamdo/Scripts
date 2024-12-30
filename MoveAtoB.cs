using UnityEngine;
using System.Collections;
public class MoveAtoB : MonoBehaviour
{
    public Transform A,B;
    float speed = 2f;

    void Start()
    {
        transform.position = A.position;
    }

    void Update()
    {
        Vector3 dir  = (B.position - A.position).normalized;
        if(Vector3.Distance(transform.position, B.position) > 0.2f)
        {
            transform.position += dir * Time.deltaTime * speed;
        }        
    }
}
