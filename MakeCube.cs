using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCube : MonoBehaviour
{
    Mesh mesh;
    Vector3[] vertices;
    int[] triangles;
    Vector2[] uvs;
    // Start is called before the first frame update
    void Start()
    {
        Vector3[] vertices =  { //Cube의 앞, 뒤, 위를 위한 12개 정점 생성        
            new Vector3 (-0.5f, -0.5f, -0.5f), //0번 버텍스 
            new Vector3 (0.5f, -0.5f, -0.5f),  //1번 버텍스 
            new Vector3 (0.5f, 0.5f, -0.5f),   //2번 버텍스 
            new Vector3 (-0.5f, 0.5f, -0.5f),  //3번 버텍스 
            new Vector3 (-0.5f, -0.5f, 0.5f),  //4번 버텍스 
            new Vector3 (0.5f, -0.5f, 0.5f),   //5번 버텍스 
            new Vector3 (0.5f, 0.5f, 0.5f),    //6번 버텍스 
            new Vector3 (-0.5f, 0.5f, 0.5f),   //7번 버텍스                                             
            new Vector3 (0.5f, 0.5f, -0.5f),   //8번 버텍스 
            new Vector3 (0.5f, 0.5f, 0.5f),    //9번 버텍스 
            new Vector3 (-0.5f, 0.5f, 0.5f),   //10번 버텍스
            new Vector3 (-0.5f, 0.5f, -0.5f),  //11번 버텍스 

        };

        // 정점 인덱스(반시계 방향)
        int[] triangles =
        {
            0,2,1, //front
            0,3,2,

            8,11,10, //top
            8,10,9,

            1,2,6, //right
            1,6,5,

            0,7,3, //left
            0,4,7,

            4,6,7, //back
            4,5,6,

            0,1,5, //bottom
            0,5,4,
        };

        Vector2[] uvs =    // 정점과 크기 동일         
        {
            new Vector2(0f, 0f), //0번
            new Vector2(1f, 0f), //1번
            new Vector2(1f, 1f), //2번
            new Vector2(0f, 1f), //3번

            new Vector2(0f, 0f), //4번
            new Vector2(1f, 0f), //5번
            new Vector2(1f, 1f), //6번
            new Vector2(0f, 1f), //7번

            new Vector2(0f, 0f), //8번
            new Vector2(1f, 0f), //9번
            new Vector2(1f, 1f), //10번
            new Vector2(0f, 1f), //11번
        };

        
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uvs;

        mesh.RecalculateNormals();
        mesh.RecalculateBounds();
        

    }

  
}
