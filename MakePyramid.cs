using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Make : MonoBehaviour
{
    Mesh mesh;
    Vector3[] vertices;
    int[] triangles;
    Vector2[] uvs;
     void Start()    
     {
        Vector3[] vertices =
           //5개 정점 생성         
        {
            new Vector3 (-0.5f, -0.5f, 0.0f), //0번 버텍스 
            new Vector3 (0.5f, -0.5f, 0.0f),  //1번 버텍스 
            new Vector3 (-0.5f, 0.5f, 0.0f),   //2번 버텍스 
            new Vector3 (0.5f, 0.5f, 0.0f),  //3번 버텍스 
            new Vector3 (0.0f , 0.0f, 1.0f),  //4번 버텍스 
        };

        int[] triangles =    
        {
            0,3,1, //front1
            3,0,2, //front2
            2,4,3, //top
            0,4,2, //left
            1,3,4, //Right
            0,1,4, //bottom
        };
        Vector2[] uvs=
        {
            new Vector2 (0f,0f),
            new Vector2(1f, 0f),
            new Vector2(0f, 1f),
            new Vector2(1f, 1f),

            new Vector2(0f, 0f),
            new Vector2(1f, 0f),
            new Vector2(1f, 1f),

            new Vector2(0f, 0f),
            new Vector2(1f, 0f),
            new Vector2(1f, 1f),

            new Vector2(0f, 0f),
            new Vector2(1f, 0f),
            new Vector2(1f, 1f),

            new Vector2(0f, 0f),
            new Vector2(1f, 0f),
            new Vector2(1f, 1f),

            new Vector2(0f, 0f),
            new Vector2(1f, 0f),
            new Vector2(1f, 1f),
        };
        Mesh mesh = GetComponent<MeshFilter>().mesh; // 정점과 삼각형 정보
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        //mesh.uv = uvs;
        mesh.RecalculateNormals(); // 면의 방향 벡터를 재계산      
        mesh.RecalculateBounds(); // 바운딩볼륨에 대한 재계산
        mesh.uv =uvs;
                                   
        print("*VertexCount: " + GetComponent<MeshFilter>().mesh.vertexCount);
        print("*IndexCount: " + GetComponent<MeshFilter>().mesh.GetIndexCount(0));
    }
}