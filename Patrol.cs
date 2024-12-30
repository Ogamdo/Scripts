using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    [SerializeField] private List<Transform> points = new List<Transform>();
    private Vector3 start, next;
    private float speed = 3f;
    private int currentIndex = 0;

    void Start()
    {
        // Points 오브젝트의 자식을 가져와 points 리스트에 추가
        Transform pointsParent = GameObject.Find("Points").transform;
        for (int i = 0; i < pointsParent.childCount; i++)
        {
            points.Add(pointsParent.GetChild(i));
        }

        // 점이 없으면 동작 중지
        if (points.Count == 0)
        {
            Debug.LogError("Points 리스트가 비어 있습니다. Points 오브젝트를 확인하세요.");
            return;
        }

        // 초기 위치 설정
        transform.position = points[0].position;
        start = points[currentIndex].position;
        next = points[(currentIndex + 1) % points.Count].position;
    }

    void Update()
    {
        if (points.Count == 0) return; // Points가 없으면 Update 중지

        Vector3 dir = (next - start).normalized; // 방향 설정

        // 목적지에 도달하지 않았으면 이동
        if (Vector3.Distance(transform.position, next) > 0.2f)
        {
            transform.position += dir * Time.deltaTime * speed;
        }
        else
        {
            // 목적지에 도달했으면 다음 위치 설정
            currentIndex = (currentIndex + 1) % points.Count;
            start = points[currentIndex].position;
            next = points[(currentIndex + 1) % points.Count].position;
        }

        // 목표 방향으로 회전
        if (dir != Vector3.zero)
        {
            Quaternion rot = Quaternion.LookRotation(dir);
            transform.rotation = Quaternion.Slerp(transform.rotation, rot, speed * Time.deltaTime);
        }
    }
}
