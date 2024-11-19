using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Vector3 SetPoint { get; private set; }

    public void SetPosition(Vector3 position)
    {
        SetPoint = position;
        transform.position = SetPoint;
        Debug.Log(transform.position);
    }
}
