using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilliardBall : MonoBehaviour
{
    private Rigidbody rigidbody;
    [SerializeField] Vector3 direction;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
        direction.Normalize();

    }
    private void FixedUpdate()
    {
        rigidbody.AddForce(direction, ForceMode.Impulse);

        // ForceMode.Force : �������� ���� �����ϴ� ����̸�,
        // ��ü�� ���� ��������� �����ϴ�
        // ������� �ð��� ����Ͽ� �����մϴ�.

        // ForceMode.Impulse : �������� ���� �����ϴ� ����̸�,
        // ��ü�� ���ӵ��� �ƴ� �ӵ��� ��ȭ��Ű�� ����Դϴ�.

        // ForceMode.VelocityChange : �������� ���� �����ϴ� ����̸�,
        // ��ü�� �ӵ��� ��ȭ��Ű�� ��ü�� ���Կ���
        // ������ ���� �ʽ��ϴ�.

        // ForceMode.Acceleration " �������� ���� �����ϴ� ����̸�,
        // ��ü�� ���� ��������� �����ϴ� ���������,
        // ��ü�� ���Կ� ���� �ʽ��ϴ�.
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        Debug.Log("OnCollisionEnter");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Goal Line")
        {
            Debug.Log("OnTriggerEnter");
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Goal Line")
        {
            Debug.Log("OnTriggerStay");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Goal Line")
        {
            Debug.Log("OnTriggerExit");
        }
    }
}
