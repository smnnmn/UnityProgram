using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    private Vector3 direction;
    public float speed = 5.0f;
    void Start()
    {
        
    }

    void Update()
    {
        // Time.deltaTime란?
        // 마지막 프레임이 완료된 후 경과한 시간입니다.

        // GetAxis와 Normalize를 동시에 사용하면 밀리는 현상이 나타난다. (정리)
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        // 벡터의 정규화
        direction.Normalize();

        transform.position = transform.position + direction * speed * Time.deltaTime;
    }
}
