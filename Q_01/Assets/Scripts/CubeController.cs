using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Vector3 SetPoint { get; set; } // set�� private ���� �����Ǿ� CubeManager���� ���� �Ұ���

    public void SetPosition()
    {
        transform.position = SetPoint;
    }
}
