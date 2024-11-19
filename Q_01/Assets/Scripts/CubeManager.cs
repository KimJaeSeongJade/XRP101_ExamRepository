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
        // SetPosition ��ġ�� �׳� ť����Ʈ�ѷ����� �����ϵ����ϱ�.
    }

    private void Start()
    {
        CreateCube();
        SetCubePosition();
    }
    private void Update()
    {
      //  SetCubePosition();
      //  ��� ��ġ�ٲٴ´�� �����϶�׷����� ������
      //  ����ȵǴϱ� �׳� ��ŸƮ���� �ѹ���
    }

    private void SetCubePosition()
    {
      //  _cubeSetPoint.x = x;
      //  _cubeSetPoint.y = y;
      //  _cubeSetPoint.z = z;
      // �ʿ���� : CubeController ���� ���Է��ϰ� �������½����� ���� 
        _cubeController.SetPosition();
    }

    private void CreateCube()
    {
        GameObject cube = Instantiate(_cubePrefab);
        _cubeController = cube.GetComponent<CubeController>();
        _cubeSetPoint = _cubeController.SetPoint;
    }
}
