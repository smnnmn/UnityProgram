using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : Ghost
{
    // Start is called before the first frame update
    void Start()
    {
        health = 50;
        speed = 5;
        Effect();
    }

    public override void Effect()
    {
        Debug.Log("���� �������� ������");
    }
}
