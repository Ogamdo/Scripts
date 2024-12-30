using UnityEngine;

public class VisionCone : MonoBehaviour 
{
    public Transform target;
    
    [Header("반지름과 시야각각")]
    public float radius = 1;
    public float angle = 4;
    private float dis;
    private Vector3 disV;
    Vector3 LeftPoint, RightPoint;
    void Start ()
    {
        dis = Vector3.Distance(target.position, transform.position);
        disV =target.position-transform.position;
    }
}