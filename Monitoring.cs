using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitoring : MonoBehaviour
{
    public float angle = 90f; // 각도 범위
    public float radius = 5f; // 감지 거리
    public LayerMask targetLayer; // 감지 대상 레이어
    public Transform target;
    private float dis;
    private Vector3 disV;
    Vector3 LeftPoint, RightPoint;
    void Start ()
    {
        dis = Vector3.Distance(target.position, transform.position);
        disV =target.position-transform.position;
    }

    void OnDrawGizmos()
    {
        // 기본 기즈모 색상
        Gizmos.color = Color.green;

        // 감지되는 오브젝트가 있는 경우 색상 변경
        Collider[] hits = Physics.OverlapSphere(transform.position, radius, targetLayer);
        if (hits.Length > 0)
        {
            Gizmos.color = Color.red; // 감지 시 빨간색
        }

        // 원뿔 시각화
        Gizmos.DrawLine(transform.position, transform.position + LeftPoint);
        Gizmos.DrawLine(transform.position, transform.position + RightPoint);
        Gizmos.DrawLine(transform.position + LeftPoint, transform.position + RightPoint);
    }

    void Update()
    {
        // 좌측 끝점 계산
        float theta = -angle / 2f * Mathf.Deg2Rad; // 각도를 라디안으로 변환
        float posX = Mathf.Cos(theta) * radius;
        float posZ = Mathf.Sin(theta) * radius;
        float posY = transform.position.y;
        LeftPoint = new Vector3(posX, posY, posZ);

        // 우측 끝점 계산
        theta = angle / 2f * Mathf.Deg2Rad;
        posX = Mathf.Cos(theta) * radius;
        posZ = Mathf.Sin(theta) * radius;
        RightPoint = new Vector3(posX, posY, posZ);
    }
}
