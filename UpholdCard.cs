using UnityEngine;
using System.Collections;
using System;

public class UpholdCard: MonoBehaviour
{
 
    Vector3[] cardPos; // 카드 위치 정보 저장
    Transform tr;    
    public float delay = 0.1f;
    public int radius = 5;
     int n = 0;
    
    void Start()   
     {
        tr = GetComponent<Transform>();               
    }
    void Update()    
    {       
        if (Input.GetMouseButton(0)) { // 클릭 시 카드의 갯수 세팅 및 펼치기 코루틴 호출
            cardPos = new Vector3[tr.childCount];
            StartCoroutine(UpholdcardPos());  
        }
    }
   
    IEnumerator UpholdcardPos()
    {
       
        
        float angle = 120/(tr.childCount-1);
        float x= radius*Mathf.Cos(angle);
        float y = radius*Mathf.Sin(angle);

        cardPos[n] = new Vector3(x, y,transform.position.z);
        n ++;
        yield return new WaitForSeconds(delay);

    }
   
}