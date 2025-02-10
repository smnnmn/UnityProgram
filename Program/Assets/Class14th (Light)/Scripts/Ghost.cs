using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ghost : MonoBehaviour
{
    [SerializeField] protected int health;
    [SerializeField] protected float speed;

    

    // Update is called once per frame
    void Update()
    {
        
    }
    public abstract void Effect();

}
