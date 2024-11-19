using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Vector3 SetPoint { get; set; } // set이 private 으로 설정되어 CubeManager에서 변경 불가능

    public void SetPosition()
    {
        transform.position = SetPoint;
    }
}
