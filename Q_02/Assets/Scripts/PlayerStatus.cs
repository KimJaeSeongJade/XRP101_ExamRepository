using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    float speed; // ������ ������ ���� StackOverflowException �ذ�

    public float MoveSpeed // StackOverflowException �߻� MoveSpeed�� get�ؼ� set�� �ݺ��Ͽ� �Ͼ�� �ɷ� Ȯ�ε�
    {
        get => speed;
        private set => speed = value; 
    }

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        MoveSpeed = 5f;
    }
}
