using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angel : Ghost
{
    // Start is called before the first frame update
    void Start()
    {
        health = 75;
        speed = 10;
        Effect();
    }


    public override void Effect()
    {
        Debug.Log("부활을 한다.");
    }
}
