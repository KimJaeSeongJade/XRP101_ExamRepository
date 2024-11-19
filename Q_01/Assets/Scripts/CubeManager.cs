using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;

    private CubeController _cubeController;
    private Vector3 _cubeSetPoint;

    private void Awake()
    {

    }

    private void Start()
    {
        CreateCube();
    }

    private void SetCubePosition(float x, float y, float z)
    {
        _cubeSetPoint.x = x;
        _cubeSetPoint.y = y;
        _cubeSetPoint.z = z;  
    }

    private void CreateCube()
    {
        GameObject cube = Instantiate(_cubePrefab);
        _cubeController = cube.GetComponent<CubeController>();

        // �ٲ� ��ġ�� _cubeSetPoint�� �������ְ�
        SetCubePosition(3, 0, 3);

        // �� ��ġ�� ť����Ʈ�ѷ��� ��ġ�� �ٲ���
        _cubeController.SetPoint = _cubeSetPoint;

        // �ٲ� ��ġ�� �����Ű�� ���� SetPosition�Լ� ���
        _cubeController.SetPosition();
    }
}
