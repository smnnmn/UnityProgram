using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject unit;
    [SerializeField] Transform[] transformList;
    [SerializeField] float createTime = 3;
    private GameObject clone;
    private float time;

    private void Update()
    {
        time += Time.deltaTime;

        if(time >= createTime)
        {
            Create();
            time = 0;
        }
    }

    private void Create()
    {
        if(clone == null)
        {
            clone = Instantiate(unit, transformList[Random.Range(0, transformList.Length)]);

        }
    }
}
