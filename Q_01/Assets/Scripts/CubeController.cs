using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] public Vector3 SetPoint; 
    // �׳� �ν����Ϳ��� 3,0,3 �����ϱ�
    public void SetPosition()
    {
        transform.position = SetPoint;
    }
}
