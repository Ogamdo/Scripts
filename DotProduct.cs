using UnityEngine;

public class DotProduct : MonoBehaviour
{
    public Transform VecR;
    public Transform VecB;
    public Transform Dot;

    void FixedUpdate()
    {
        float dot = Vector3.Dot(VecR.forward, VecB.forward);
        Dot.localScale = new Vector3(1f, dot*3, 1f);
        VecB.transform.Rotate(0, Time.deltaTime*100, 0);
        //Dot.transform.Translate(0, 0, Time.deltaTime);
        
    }
}
