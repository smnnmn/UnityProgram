using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mutant : Ghost
{
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        speed = 20;
        Effect();
    }

    public override void Effect()
    {
        Debug.Log("ü���� �������� �̵��ӵ��� ��������.");
    }
}
