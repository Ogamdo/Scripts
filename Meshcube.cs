using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meshcube : MonoBehaviour
{
   public List<Vector3> vertexList = new List<Vector3>(); // 정점 위치를 담을 리스트
    public GameObject cube; // 정점 위치에 생성할 큐브(scale=0.05) 연결

    void Start()    
    {        
        GetComponent<MeshFilter>().mesh.GetVertices(vertexList); //메쉬필터의 메쉬정보 저장

        for (int i = 0; i < vertexList.Count; i++)        
        {
            GameObject obj = Instantiate(cube);
            obj.transform.parent = transform;
            obj.transform.position = vertexList[i] + transform.position;
        }

    }
}
