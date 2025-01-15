using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private float weight;
    
    public float radius = 15;

    private void Awake()
    {
        // Awake �Լ���?
        // ���� ������Ʈ�� �����Ǵ� ������ �� �� ����
        // ȣ��Ǹ� ��ũ��Ʈ�� ��Ȱ��ȭ�� ������ ����
        // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        // OnEnalbe �Լ���?
        // ���� ������Ʈ�� Ȱ��ȭ�Ǵ� ������ ȣ��Ǵ�
        // �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("OnEnable");
    }

    private void Start()
    {
        // Start �Լ���?
        // ���� ������Ʈ�� �����Ǵ� ������ �� �ѹ��� ȣ��Ǹ�,
        // ��ũ��Ʈ�� ��Ȱ��ȭ�� ������ �� ȣ����� �ʴ� �̺�Ʈ �Լ��Դϴ�.


        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        // FixedUpdate �Լ���?
        // TimeStep�� ������ ���� ���� ������ �������� ȣ��Ǵ�
        // �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("Fixed Updata");
    }

    private void Update()
    {
        // Updata �Լ���?
        // �� �����Ӹ��� ȣ��Ǹ�, ����� ���ɿ� ���� Framerate��
        // �ٲ� �� �ִ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // LateUpdate �Լ���?
        // Update �Լ��� ȣ��ǰ� �״������� �� �����Ӹ��� ȣ��Ǵ�
        // �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("LateUpdate");
    }

    private void OnDisable()
    {
        // OnDisable �Լ���?
        // ���� ������Ʈ�� ��Ȱ��ȭ�Ǿ��� ��
        // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        // OnDestroy �Լ���?
        // ���� ������Ʈ�� �����Ǿ��� ��
        // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("OnDestroy");
    }
}
