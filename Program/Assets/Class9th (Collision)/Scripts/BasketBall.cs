using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBall : MonoBehaviour, IDamageable
{
    public void Use()
    {
        Debug.Log("이 공은 농구공이다.");
    }
}
